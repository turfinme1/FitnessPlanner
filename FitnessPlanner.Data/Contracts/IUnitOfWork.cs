namespace FitnessPlanner.Data.Contracts
{
    /// <summary>
    /// Interface for the unit of work pattern, providing access to repositories for different entities.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets the repository for managing <see cref="WorkoutPlan"/> entities.
        /// </summary>
        IWorkoutPlanRepository WorkoutPlans { get; }

        /// <summary>
        /// Gets the repository for managing <see cref="SingleWorkout"/> entities.
        /// </summary>
        ISingleWorkoutRepository SingleWorkouts { get; }

        /// <summary>
        /// Gets the repository for managing <see cref="Exercise"/> entities.
        /// </summary>
        IExerciseRepository Exercises { get; }

        /// <summary>
        /// Gets the repository for managing <see cref="User"/> entities.
        /// </summary>
        IUserRepository Users { get; }

        /// <summary>
        /// Gets the repository for managing <see cref="Goal"/> entities.
        /// </summary>
        IGoalRepository Goals { get; }

        /// <summary>
        /// Gets the repository for managing <see cref="SkillLevel"/> entities.
        /// </summary>
        ISkillLevelRepository SkillLevels { get; }

        /// <summary>
        /// Gets the repository for managing <see cref="BodyMassIndexMeasure"/> entities.
        /// </summary>
        IBodyMassIndexMeasureRepository BodyMassIndexMeasures { get; }

        /// <summary>
        /// Saves changes asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task SaveChangesAsync();
    }
}
