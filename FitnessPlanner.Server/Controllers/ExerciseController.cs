using FitnessPlanner.Server.Extensions;
using FitnessPlanner.Server.Models;
using FitnessPlanner.Services.Exercise.Contracts;
using FitnessPlanner.Services.Models.Exercise;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FitnessPlanner.Server.Controllers
{
    /// <summary>
    /// Controller class for handling HTTP requests related to exercises.
    /// </summary>
    /// <param name="exerciseService">Service for handling exercise operations.</param>
    /// <param name="logger">Logger for logging information and errors.</param>
    [ApiController]
    [Route("api/exercise")]
    public class ExerciseController(
        IExerciseService exerciseService,
        ILogger<ExerciseController> logger) : BaseController
    {
        /// <summary>
        /// Retrieves all exercises.
        /// </summary>
        /// <returns>A list of <see cref="ExerciseDisplayDto"/></returns>
        /// <response code="200">Returns the collection of exercises.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpGet]
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<IEnumerable<ExerciseDisplayDto>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllExercises() =>
             (await exerciseService.GetAllAsync()).ToActionResult();

        /// <summary>
        /// Retrieves a specific exercise by its ID.
        /// </summary>
        /// <param name="id">The ID of the exercise to retrieve.</param>
        /// <returns>The <see cref="ExerciseDisplayDto"/> with the specified ID.</returns>
        /// <response code="200">Returns the exercise with the specified ID.</response>
        /// <response code="404">If no exercise with the specified ID is found.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpGet("{id:int}")]
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<ExerciseDisplayDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetExerciseById(int id) =>
            (await exerciseService.GetByIdAsync(id)).ToActionResult();

        /// <summary>
        /// Retrieves all exercises for a specific muscle group.
        /// </summary>
        /// <param name="muscleGroup">The name of the muscle group</param>
        /// <returns>A list of <see cref="ExerciseDisplayDto"/> with the specific muscle group</returns>
        /// <response code="200">Returns the collection of exercises for the specified muscle group.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="404">If no exercises with the specified muscle group are found.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpGet("{muscleGroup}")]
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<IEnumerable<ExerciseDisplayDto>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetExercisesByMuscleGroup(string muscleGroup) =>
            (await exerciseService.GetAllByMuscleGroupAsync(muscleGroup)).ToActionResult();

        /// <summary>
        /// Creates a new exercise.
        /// </summary>
        /// <param name="exerciseCreateDto">The exercise data.</param>
        /// <returns>The newly created <see cref="ExerciseDisplayDto"/></returns>
        /// <response code="201">Returns the newly created exercise.</response>
        /// <response code="401">If the user is not authorized.</response>
        /// <response code="403">If the user is forbidden to perform the operation.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse<ExerciseDisplayDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateExercise([FromBody] ExerciseCreateDto exerciseCreateDto) =>
            (await exerciseService.CreateAsync(exerciseCreateDto)).ToActionResult();

        /// <summary>
        /// Updates an existing exercise.
        /// </summary>
        /// <param name="id">The ID of the exercise to update.</param>
        /// <param name="exerciseUpdateDto">The updated exercise data.</param>
        /// <returns>No content response if successful</returns>
        /// <response code="200">If the exercise was successfully updated.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="401">If the user is not authorized.</response>
        /// <response code="403">If the user is forbidden to perform the operation.</response>
        /// <response code="404">If no exercise with the specified ID is found.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpPut("{id:int}")]
        [Authorize(Roles = "Admin")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateExercise(int id, [FromBody] ExerciseUpdateDto exerciseUpdateDto) =>
            (await exerciseService.UpdateAsync(id, exerciseUpdateDto)).ToActionResult();

        /// <summary>
        /// Deletes an existing exercise.
        /// </summary>
        /// <param name="id">The ID of the exercise to delete.</param>
        /// <returns>No content response if successful</returns>
        /// <response code="200">If the exercise was successfully deleted.</response>
        /// <response code="400">If the request is invalid.</response>
        /// <response code="401">If the user is not authorized.</response>
        /// <response code="403">If the user is forbidden to perform the operation.</response>
        /// <response code="404">If no exercise with the specified ID is found.</response>
        /// <response code="422">If the request could not be processed.</response>
        /// <response code="500">If an unexpected internal error occurs.</response>
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteExercise(int id) =>
            (await exerciseService.DeleteAsync(id)).ToActionResult();
    }
}
