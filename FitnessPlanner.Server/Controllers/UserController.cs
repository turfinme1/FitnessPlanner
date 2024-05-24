using FitnessPlanner.Services.CosineSimilarityCalculation.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Services.ApplicationUser.Contracts;
using FitnessPlanner.Services.Models.User;
using FitnessPlanner.Services.Models.WorkoutPlan;

namespace FitnessPlanner.Server.Controllers
{
    /// <summary>
    /// Controller class for handling HTTP requests related to users.
    /// </summary>
    /// <param name="similarityCalculationService"></param>
    /// <param name="logger"></param>
    [ApiController]
    [Route("api/user")]
    public class UserController(
        IUserService userService,
        ICosineSimilarityCalculationService similarityCalculationService,
        ILogger<UserController> logger) : BaseController
    {
        /// <summary>
        /// Gets a workout plan recommendation for the user.
        /// </summary>
        /// <returns>The <see cref="WorkoutPlanDto"/> recommendation.</returns>
        [HttpGet("recommendation")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<WorkoutPlanDto>> GetWorkoutRecommendation()
        {
            var userId = User.FindFirstValue((ClaimTypes.NameIdentifier));
            //var userId2 = "b40ab47f-7216-47af-a157-43003b1d261f";

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

        /// <summary>
        /// Updates the user's data.
        /// </summary>
        /// <param name="userData"></param>
        /// <returns>No content response if successful</returns>
        [HttpPut("update-data")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateOwnData([FromBody] UserDataUpdateDto userData)
        {   
            if (User.FindFirstValue(ClaimTypes.NameIdentifier) != userData.Id)
            {
                return Unauthorized();
            }

            try
            {   
                var result = await userService.UpdateAsync(userData);

                if (result.Succeeded)
                {
                    return NoContent();
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetWorkoutRecommendation)}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
