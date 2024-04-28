using FitnessPlanner.Data.Contracts;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class UnitOfWork(
        ApplicationDbContext context,
        IWorkoutPlanRepository workoutPlans,
        ISingleWorkoutRepository singleWorkouts,
        IExerciseRepository exercises) : IUnitOfWork
    {
        public IWorkoutPlanRepository WorkoutPlans { get; } = workoutPlans;
        public ISingleWorkoutRepository SingleWorkouts { get; } = singleWorkouts;
        public IExerciseRepository Exercises { get; } = exercises;

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
