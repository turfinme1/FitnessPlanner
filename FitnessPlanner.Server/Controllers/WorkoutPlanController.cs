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
    }
}
