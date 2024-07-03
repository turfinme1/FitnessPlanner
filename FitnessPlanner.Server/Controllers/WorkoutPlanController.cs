using FitnessPlanner.Services.Models.WorkoutPlan;
using FitnessPlanner.Services.WorkoutPlan.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitnessPlanner.Server.Controllers
{
    /// <summary>
    /// Controller class for handling HTTP requests related to workout plans.
    /// </summary>
    /// <param name="workoutPlanService">Service for handling operations related to workout plan</param>
    /// <param name="logger">Logger for logging information and errors.</param>
    [ApiController]
    [Route("api/workout-plan")]
    public class WorkoutPlanController(
        IWorkoutPlanService workoutPlanService,
        ILogger<WorkoutPlanController> logger) : BaseController
    {
        /// <summary>
        /// Retrieves all workout plans.
        /// </summary>
        /// <returns>A list of <see cref="WorkoutPlanDto"/></returns>
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<WorkoutPlanDto>>> GetAllWorkoutPlans()
        {
            try
            {
                return Ok(await workoutPlanService.GetAllAsync());
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllWorkoutPlans)}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Retrieves a specific workout plan by its ID.
        /// </summary>
        /// <param name="id">The ID of the workout plan to retrieve.</param>
        /// <returns>The <see cref="WorkoutPlanDto"/> with the specified ID.</returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<WorkoutPlanDto>> GetWorkoutPlanById(int id)
        {
            try
            {
                var workoutPlan = await workoutPlanService.GetByIdAsync(id);
                if (workoutPlan == null)
                {
                    return NotFound();
                }

                return Ok(workoutPlan);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetWorkoutPlanById)}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Creates a new workout plan.
        /// </summary>
        /// <param name="workoutPlanDto">The workout plan data.</param>
        /// <returns>The newly created <see cref="WorkoutPlanDto"/></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<WorkoutPlanDto>> CreateWorkoutPlan([FromBody] WorkoutPlanCreateDto workoutPlanDto)
        {
            if (User.FindFirstValue(ClaimTypes.NameIdentifier) != workoutPlanDto.UserId)
            {
                return Unauthorized();
            }

            try
            {
                var createdWorkoutPlanId = await workoutPlanService.CreateAsync(workoutPlanDto);

                var createdWorkoutPlan = await workoutPlanService.GetByIdAsync(createdWorkoutPlanId);

                return CreatedAtAction(nameof(GetWorkoutPlanById), new { id = createdWorkoutPlanId },
                    createdWorkoutPlan);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(CreateWorkoutPlan)}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Updates an existing workout plan.
        /// </summary>
        /// <param name="id">The ID of the workout plan to update.</param>
        /// <param name="workoutPlanDto">The updated workout plan data.</param>
        /// <returns>No content response if successful</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateWorkoutPlan(int id, [FromBody] WorkoutPlanUpdateDto workoutPlanDto)
        {
            if (id != workoutPlanDto.Id)
            {
                return BadRequest();
            }

            if (User.FindFirstValue(ClaimTypes.NameIdentifier) != workoutPlanDto.UserId)
            {
                return Unauthorized();
            }

            try
            {
                await workoutPlanService.UpdateAsync(workoutPlanDto);

                return NoContent();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(UpdateWorkoutPlan)}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Deletes an existing workout plan.
        /// </summary>
        /// <param name="id">The ID of the workout plan to delete.</param>
        /// <returns>No content response if successful</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteWorkoutPlan(int id)
        {
            var workoutPlan = await workoutPlanService.GetByIdAsDeleteDtoAsync(id);
            if (workoutPlan == null)
            {
                return BadRequest();
            }

            if (User.FindFirstValue(ClaimTypes.NameIdentifier) != workoutPlan.UserId)
            {
                return Unauthorized();
            }

            try
            {
                await workoutPlanService.DeleteAsync(id);
                //TODO: Improve delete logic
                return Ok();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(DeleteWorkoutPlan)}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
