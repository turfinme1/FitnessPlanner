using FitnessPlanner.Services.Exercise.Contracts;
using FitnessPlanner.Services.Models.Exercise;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ExerciseDisplayDto>> GetExerciseById(int id)
        {
            try
            {
                var exercise = await exerciseService.GetById(id);

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
    }
}
