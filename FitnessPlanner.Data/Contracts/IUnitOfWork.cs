namespace FitnessPlanner.Data.Contracts
{
    public interface IUnitOfWork
    {
        IWorkoutPlanRepository WorkoutPlans { get; }

        ISingleWorkoutRepository SingleWorkouts { get; }

        IExerciseRepository Exercises { get; }

        IUserRepository Users { get; }

        IGoalRepository Goals { get; }

        ISkillLevelRepository SkillLevels { get; }

        IBodyMassIndexMeasureRepository BodyMassIndexMeasures { get; }

        Task SaveChangesAsync();
    }
}
