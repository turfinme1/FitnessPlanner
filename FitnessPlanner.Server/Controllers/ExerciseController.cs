using FitnessPlanner.Services.Exercise.Contracts;
using FitnessPlanner.Services.Models.Exercise;
using FitnessPlanner.Services.WorkoutPlan;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitnessPlanner.Server.Controllers
{
    /// <summary>
    /// Controller class for handling HTTP requests related to exercises.
    /// </summary>
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
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ExerciseDisplayDto>>> GetAllExercises()
        {
            try
            {
                return Ok(await exerciseService.GetAllAsync());
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllExercises)}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Retrieves a specific exercise by its ID.
        /// </summary>
        /// <param name="id">The ID of the exercise to retrieve.</param>
        /// <returns>The <see cref="ExerciseDisplayDto"/> with the specified ID.</returns>
        [HttpGet("{id:int}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ExerciseDisplayDto>> GetExerciseById(int id)
        {
            try
            {
                var exercise = await exerciseService.GetByIdAsync(id);

                if (exercise == null)
                {
                    return NotFound();
                }

                return Ok(exercise);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetExerciseById)}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Retrieves all exercises for a specific muscle group.
        /// </summary>
        /// <param name="muscleGroup">The name of the muscle group</param>
        /// <returns>A list of <see cref="ExerciseDisplayDto"/> with the specific muscle group</returns>
        [HttpGet("{muscleGroup}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ExerciseDisplayDto>>> GetExercisesByMuscleGroup(string muscleGroup)
        {
            try
            {
                var exercises = await exerciseService.GetAllByMuscleGroupAsync(muscleGroup);

                if (exercises == null)
                {
                    return NotFound();
                }

                return Ok(exercises);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetExercisesByMuscleGroup)}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Creates a new exercise.
        /// </summary>
        /// <param name="exerciseCreateDto">The exercise data.</param>
        /// <returns>The newly created <see cref="ExerciseDisplayDto"/></returns>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ExerciseDisplayDto>> CreateExercise([FromBody] ExerciseCreateDto exerciseCreateDto)
        {
            try
            {
                var createdExerciseId = await exerciseService.CreateAsync(exerciseCreateDto);
                var createdExercise = await exerciseService.GetByIdAsync(createdExerciseId);

                return CreatedAtAction(nameof(GetExerciseById), new { id = createdExerciseId }, createdExercise);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(CreateExercise)}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Updates an existing exercise.
        /// </summary>
        /// <param name="id">The ID of the exercise to update.</param>
        /// <param name="exerciseUpdateDto">The updated exercise data.</param>
        /// <returns>No content response if successful</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ExerciseDisplayDto>> UpdateExercise(int id, [FromBody] ExerciseUpdateDto exerciseUpdateDto)
        {
            if (id != exerciseUpdateDto.Id)
            {
                return BadRequest();
            }

            try
            {
                await exerciseService.UpdateAsync(exerciseUpdateDto);

                return NoContent();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(UpdateExercise)}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Deletes an existing exercise.
        /// </summary>
        /// <param name="id">The ID of the exercise to delete.</param>
        /// <returns>No content response if successful</returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteExercise(int id)
        {
            var workoutPlan = await exerciseService.GetByIdAsDeleteDtoAsync(id);
            if (workoutPlan == null)
            {
                return BadRequest();
            }

            try
            {
                await exerciseService.DeleteAsync(id);
                //TODO: Improve delete logic
                return Ok();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(DeleteExercise)}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
