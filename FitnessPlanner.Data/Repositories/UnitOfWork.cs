using FitnessPlanner.Data.Contracts;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class UnitOfWork(
        ApplicationDbContext context,
        IWorkoutPlanRepository workoutPlans,
        ISingleWorkoutRepository singleWorkouts,
        IExerciseRepository exercises,
        IGoalRepository goals,
        ISkillLevelRepository skillLevels,
        IBodyMassIndexMeasureRepository bodyMassIndexMeasures,
        IUserRepository users) : IUnitOfWork
    {
        public IWorkoutPlanRepository WorkoutPlans { get; } = workoutPlans;
        public ISingleWorkoutRepository SingleWorkouts { get; } = singleWorkouts;
        public IExerciseRepository Exercises { get; } = exercises;
        public IGoalRepository Goals { get; } = goals;
        public ISkillLevelRepository SkillLevels { get; } = skillLevels;
        public IBodyMassIndexMeasureRepository BodyMassIndexMeasures { get; } = bodyMassIndexMeasures;
        public IUserRepository Users { get; } = users;

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
