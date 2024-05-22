using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class WorkoutPlanRepository(ApplicationDbContext context) : Repository<WorkoutPlan>(context), IWorkoutPlanRepository
    {
        public async Task<List<WorkoutPlan>> GetAllWithRelatedEntitiesAsync()
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
