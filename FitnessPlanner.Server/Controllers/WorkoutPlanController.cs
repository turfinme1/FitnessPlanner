using System.Security.Claims;
using FitnessPlanner.Services.Models.WorkoutPlan;
using FitnessPlanner.Services.WorkoutPlan.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessPlanner.Server.Controllers
{
    [Route("api/workout-plan")]
    [ApiController]
    public class WorkoutPlanController(
        IWorkoutPlanService workoutPlanService,
        ILogger<WorkoutPlanController> logger) : BaseController
    {

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

        [HttpPost]
        [AllowAnonymous]
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

        [HttpPut("{id}")]
        [AllowAnonymous]
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

            //if (User.FindFirstValue(ClaimTypes.NameIdentifier) != workoutPlanDto.UserId)
            //{
            //    return Unauthorized();
            //}

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

        [HttpDelete("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteWorkoutPlan(int id)
        {
            var workoutPlan = await workoutPlanService.GetByIdAsync(id);
            if (workoutPlan == null)
            {
                return BadRequest();
            }

            //if (User.FindFirstValue(ClaimTypes.NameIdentifier) != workoutPlan.UserId)
            //{
            //    return Unauthorized();
            //}

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
