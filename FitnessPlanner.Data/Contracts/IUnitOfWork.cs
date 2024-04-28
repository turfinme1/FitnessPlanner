namespace FitnessPlanner.Data.Contracts
{
    public interface IUnitOfWork
    {
        IWorkoutPlanRepository WorkoutPlans { get; }

        ISingleWorkoutRepository SingleWorkouts { get; }

        IExerciseRepository Exercises { get; }

        Task SaveChangesAsync();
    }
}
