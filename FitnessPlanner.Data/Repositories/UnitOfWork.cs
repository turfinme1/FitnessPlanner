using FitnessPlanner.Data.Contracts;

namespace FitnessPlanner.Data.Repositories
{
    /// <summary>
    /// Represents a unit of work for coordinating operations across multiple repositories.
    /// </summary>
    /// <param name="context">The application database context.</param>
    /// <param name="workoutPlans">The repository for managing workout plan entities.</param>
    /// <param name="singleWorkouts">The repository for managing single workout entities.</param>
    /// <param name="exercises">The repository for managing exercise entities.</param>
    /// <param name="goals">The repository for managing goal entities.</param>
    /// <param name="skillLevels">The repository for managing skill level entities.</param>
    /// <param name="bodyMassIndexMeasures">The repository for managing body mass index measure entities.</param>
    /// <param name="users">The repository for managing user entities.</param>
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
        /// <summary>
        /// Gets the repository for managing <see cref="WorkoutPlan"/> entities.
        /// </summary>
        public IWorkoutPlanRepository WorkoutPlans { get; } = workoutPlans;
        
        /// <summary>
        /// Gets the repository for managing <see cref="SingleWorkout"/> entities.
        /// </summary>
        public ISingleWorkoutRepository SingleWorkouts { get; } = singleWorkouts;

        /// <summary>
        /// Gets the repository for managing <see cref="Exercise"/> entities.
        /// </summary>
        public IExerciseRepository Exercises { get; } = exercises;

        /// <summary>
        /// Gets the repository for managing <see cref="Goal"/> entities.
        /// </summary>
        public IGoalRepository Goals { get; } = goals;

        /// <summary>
        /// Gets the repository for managing <see cref="SkillLevel"/> entities.
        /// </summary>
        public ISkillLevelRepository SkillLevels { get; } = skillLevels;

        /// <summary>
        /// Gets the repository for managing <see cref="BodyMassIndexMeasure"/> entities.
        /// </summary>
        public IBodyMassIndexMeasureRepository BodyMassIndexMeasures { get; } = bodyMassIndexMeasures;

        /// <summary>
        /// Gets the repository for managing <see cref="User"/> entities.
        /// </summary>
        public IUserRepository Users { get; } = users;

        /// <summary>
        /// Saves all changes made in this context to the underlying database asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous save operation.</returns>
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
