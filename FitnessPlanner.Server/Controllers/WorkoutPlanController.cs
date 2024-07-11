using FitnessPlanner.Server.Extensions;
using FitnessPlanner.Server.Models;
using FitnessPlanner.Services.Models.WorkoutPlan;
using FitnessPlanner.Services.WorkoutPlan.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
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
        /// <returns>A list of <see cref="WorkoutPlanDisplayDto"/></returns>
        /// <response code="200">Returns the collection of workout plans.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpGet]
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<IEnumerable<WorkoutPlanDisplayDto>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllWorkoutPlans() =>
            (await workoutPlanService.GetAllAsync()).ToActionResult();

        /// <summary>
        /// Retrieves a specific workout plan by its ID.
        /// </summary>
        /// <param name="id">The ID of the workout plan to retrieve.</param>
        /// <returns>The <see cref="WorkoutPlanDisplayDto"/> with the specified ID.</returns>
        /// <response code="200">Returns the workout plan with the specified ID.</response>
        /// <response code="404">If no workout plan with the specified ID is found.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<WorkoutPlanDisplayDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWorkoutPlanById(int id) =>
            (await workoutPlanService.GetByIdAsync(id)).ToActionResult();

        /// <summary>
        /// Creates a new workout plan.
        /// </summary>
        /// <param name="workoutPlanDto">The workout plan data.</param>
        /// <returns>The newly created <see cref="WorkoutPlanDisplayDto"/></returns>
        /// <response code="200">Returns the newly created workout plan.</response>
        /// <response code="401">If the user is not authorized.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<WorkoutPlanDisplayDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateWorkoutPlan([FromBody] WorkoutPlanCreateDto workoutPlanDto)
        {
            var userClaimId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return (await workoutPlanService.CreateAsync(userClaimId, workoutPlanDto)).ToActionResult();
        }

        /// <summary>
        /// Updates an existing workout plan.
        /// </summary>
        /// <param name="id">The ID of the workout plan to update.</param>
        /// <param name="workoutPlanDto">The updated workout plan data.</param>
        /// <returns>No content response if successful</returns>
        /// <response code="200">If the workout plan was successfully updated.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="401">If the user is not authorized.</response>
        /// <response code="404">If no workout plan with the specified ID is found.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateWorkoutPlan(int id, [FromBody] WorkoutPlanUpdateDto workoutPlanDto)
        {
            var userClaimId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return (await workoutPlanService.UpdateAsync(id, userClaimId, workoutPlanDto)).ToActionResult();
        }

        /// <summary>
        /// Deletes an existing workout plan.
        /// </summary>
        /// <param name="id">The ID of the workout plan to delete.</param>
        /// <returns>No content response if successful</returns>
        /// <response code="200">If the workout plan was successfully deleted.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="401">If the user is not authorized.</response>
        /// <response code="404">If no workout plan with the specified ID is found.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpDelete("{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteWorkoutPlan(int id)
        {
            var userClaimId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return (await workoutPlanService.DeleteAsync(userClaimId, id)).ToActionResult();
        }
    }
}
