using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data.Repositories
{
    /// <summary>
    /// Repository class for handling data operations related to exercises.
    /// </summary>
    /// <param name="context">The database context to be used by the repository.</param>
    public sealed class ExerciseRepository(ApplicationDbContext context) : Repository<Exercise>(context), IExerciseRepository
    {
        /// <summary>
        /// Retrieves all exercises along with their related entities asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of <see cref="Exercise"/> objects with their related entities.
        /// </returns>
        public async Task<IEnumerable<Exercise>> GetAllWithRelatedEntitiesAsync()
        {
            return await base.DbSet
                .Include(e => e.ExerciseMuscleGroups)
                .ThenInclude(emg => emg.MuscleGroup)
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves an exercise by its ID along with its related entities asynchronously.
        /// </summary>
        /// <param name="id">The ID of the exercise to retrieve.</param>
        /// <param name="isTracked">Indicates whether the entity should be tracked by the context.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the <see cref="Exercise"/> with its related entities, or null if no exercise with the specified ID is found.
        /// </returns>
        public async Task<Exercise?> GetByIdWithRelatedEntitiesAsync(int id, bool isTracked = false)
        {
            var query = base.DbSet
                .Include(e => e.ExerciseMuscleGroups)
                .ThenInclude(emg => emg.MuscleGroup);

            return isTracked
                ? await query.FirstOrDefaultAsync(wp => wp.Id == id)
                : await query.AsNoTracking().FirstOrDefaultAsync(wp => wp.Id == id);
        }
    }
}
