using FitnessPlanner.Server.Extensions;
using FitnessPlanner.Server.Models;
using FitnessPlanner.Services.ApplicationUser.Contracts;
using FitnessPlanner.Services.CosineSimilarityCalculation.Contracts;
using FitnessPlanner.Services.Models.User;
using FitnessPlanner.Services.Models.WorkoutPlan;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Security.Claims;

namespace FitnessPlanner.Server.Controllers
{
    /// <summary>
    /// Controller class for handling HTTP requests related to users.
    /// </summary>
    /// <param name="userService">Service for handling user operations.</param>
    /// <param name="similarityCalculationService">Service for calculating similarity between user and workout plan properties.</param>
    /// <param name="logger">Logger for logging information and errors.</param>
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
        /// <returns>The <see cref="WorkoutPlanDisplayDto"/> recommendation.</returns>
        /// <response code="200">Returns the workout plan recommendation.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpGet("recommendation")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<IEnumerable<WorkoutPlanDisplayDto>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWorkoutRecommendation()
        {
            var userId = User.FindFirstValue((ClaimTypes.NameIdentifier));

            return (await similarityCalculationService.GetWorkoutIdRecommendationByUserIdAsync(userId)).ToActionResult();
        }

        /// <summary>
        /// Updates the user's data.
        /// </summary>
        /// <param name="userData"></param>
        /// <returns>The updated user data</returns>
        /// <response code="200">If the user data was successfully updated.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpPut("update-data")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateOwnData([FromBody] UserDataUpdateDto userData)
        {
            var userClaimId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return (await userService.UpdateAsync(userClaimId, userData)).ToActionResult();
        }

        /// <summary>
        /// Gets the user's own data as form DTO.
        /// </summary>
        /// <returns>The <see cref="WorkoutPlanDisplayDto"/> representing user's own data </returns>
        /// <response code="200">Returns the user's own data.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="401">If the user is not authenticated.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpGet("form-data")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<UserDataFormDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetOwnUserData()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return (await userService.GetByIdAsUserDataFormDtoAsync(userId)).ToActionResult();
        }
    }
}
