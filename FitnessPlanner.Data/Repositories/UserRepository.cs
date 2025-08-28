using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data.Repositories
{
    /// <summary>
    /// Repository class for handling data operations related to users.
    /// </summary>
    /// <param name="context">The database context to be used by the repository.</param>
    public sealed class UserRepository(ApplicationDbContext context) : Repository<User>(context), IUserRepository
    {
        /// <summary>
        /// Retrieves all users along with their related entities asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of <see cref="User"/> objects with their related entities.
        /// </returns>
        public async Task<IEnumerable<User>> GetAllWithRelatedEntitiesAsync()
        {
            return await base.DbSet
                .Include(u => u.SkillLevel)
                .Include(u => u.Goal)
                .Include(u => u.BodyMassIndexMeasure)
                .Include(u=> u.UserWorkoutPlans)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves a <see cref="User"/> by its ID along with its related entities asynchronously.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the <see cref="User"/> with its related entities, or null if no user with the specified ID is found.
        /// </returns>
        public async Task<User?> GetByIdWithRelatedEntitiesAsync(string id, bool isTracked = false)
        {
            var query = base.DbSet
                .Include(u => u.SkillLevel)
                .Include(u => u.Goal)
                .Include(u => u.BodyMassIndexMeasure)
                .Include(u => u.UserWorkoutPlans)
                .Include(u => u.UserWorkoutPlans)
                .ThenInclude(uwp => uwp.WorkoutPlan)
                        .ThenInclude(wp => wp.Goal)
                .Include(u => u.UserWorkoutPlans)
                    .ThenInclude(uwp => uwp.WorkoutPlan)
                        .ThenInclude(wp => wp.SkillLevel)
                .Include(u => u.UserWorkoutPlans)
                    .ThenInclude(uwp => uwp.WorkoutPlan)
                        .ThenInclude(wp => wp.SingleWorkoutWorkoutPlans)
                            .ThenInclude(swp => swp.SingleWorkout)
                                .ThenInclude(sw => sw.ExercisePerformInfoSingleWorkouts)
                                    .ThenInclude(episw => episw.ExercisePerformInfo)
                                        .ThenInclude(epi => epi.Exercise);

            return isTracked
                ? await query.FirstOrDefaultAsync(u => u.Id == id)
                : await query.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
