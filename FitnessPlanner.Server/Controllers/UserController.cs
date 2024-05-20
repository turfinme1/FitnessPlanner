using FitnessPlanner.Services.ApplicationUser.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using FitnessPlanner.Services.CosineSimilarityCalculation.Contracts;

namespace FitnessPlanner.Server.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController(
        ICosineSimilarityCalculationService similarityCalculationService, 
        ILogger<UserController> logger) : BaseController
    {
        [HttpGet("recommendation")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetWorkoutRecommendation()
        {
            var userId = User.FindFirstValue((ClaimTypes.NameIdentifier));

            try
            {
                return Ok(await similarityCalculationService.GetWorkoutIdRecommendationByUserIdAsync(userId));
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetWorkoutRecommendation)}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
