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
                logger.LogError(e, $"Error in {nameof(WorkoutPlanController.GetAllWorkoutPlans)}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
