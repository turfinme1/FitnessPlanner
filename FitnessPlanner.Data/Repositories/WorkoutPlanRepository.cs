using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data.Repositories
{
    /// <summary>
    /// Repository class for handling data operations related to workout plans.
    /// </summary>
    /// <param name="context">The database context to be used by the repository.</param>
    public sealed class WorkoutPlanRepository(ApplicationDbContext context) : Repository<WorkoutPlan>(context), IWorkoutPlanRepository
    {
        /// <summary>
        /// Retrieves all workout plans along with their related entities asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of <see cref="WorkoutPlan"/> objects with their related entities.
        /// </returns>
        public async Task<IEnumerable<WorkoutPlan>> GetAllWithRelatedEntitiesAsync()
        {
            return await base.DbSet
                .Include(wp => wp.SingleWorkoutWorkoutPlans)
                .ThenInclude(swp => swp.SingleWorkout)
                .ThenInclude(sw => sw.ExercisePerformInfoSingleWorkouts)
                .ThenInclude(episw => episw.ExercisePerformInfo)
                .ThenInclude(epi => epi.Exercise)
                .Include(wp => wp.WorkoutPlanBodyMassIndexMeasures)
                .ThenInclude(xp => xp.BodyMassIndexMeasure)
                .Include(wp => wp.SkillLevel)
                .Include(wp => wp.Goal)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a <see cref="WorkoutPlan"/> by its ID along with its related entities asynchronously.
        /// </summary>
        /// <param name="id">The ID of the workout plan to retrieve.</param>
        /// <param name="isTracked">Indicates whether the entity should be tracked by the context.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the <see cref="WorkoutPlan"/> with its related entities, or null if no workout plan with the specified ID is found.
        /// </returns>
        public async Task<WorkoutPlan?> GetByIdWithRelatedEntitiesAsync(int id, bool isTracked = false)
        {
            var query = base.DbSet
                .Include(wp => wp.SingleWorkoutWorkoutPlans)
                .ThenInclude(swp => swp.SingleWorkout)
                .ThenInclude(sw => sw.ExercisePerformInfoSingleWorkouts)
                .ThenInclude(episw => episw.ExercisePerformInfo)
                .ThenInclude(epi => epi.Exercise)
                .Include(wp => wp.SkillLevel)
                .Include(wp => wp.Goal);

            return isTracked
                ? await query.FirstOrDefaultAsync(wp => wp.Id == id)
                : await query.AsNoTracking().FirstOrDefaultAsync(wp => wp.Id == id);
        }
    }
}
