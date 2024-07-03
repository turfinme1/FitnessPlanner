using FitnessPlanner.Data.Configuration;
using FitnessPlanner.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MuscleGroupConfiguration());
            builder.ApplyConfiguration(new ExerciseConfiguration());
            builder.ApplyConfiguration(new ExerciseMuscleGroupConfiguration());

            builder.ApplyConfiguration(new ExercisePerformInfoConfiguration());
            builder.ApplyConfiguration(new SingleWorkoutConfiguration());
            builder.ApplyConfiguration(new ExercisePerformInfoSingleWorkoutConfiguration());

            builder.ApplyConfiguration(new BodyMassIndexMeasureConfiguration());
            builder.ApplyConfiguration(new SkillLevelConfiguration());
            builder.ApplyConfiguration(new GoalConfiguration());

            builder.ApplyConfiguration(new WorkoutPlanConfiguration());
            builder.ApplyConfiguration(new SingleWorkoutWorkoutPlanConfiguration());
            builder.ApplyConfiguration(new WorkoutPlanBodyMassIndexMeasureConfiguration());

            base.OnModelCreating(builder);
        }

        public required DbSet<MuscleGroup> MuscleGroups { get; set; } = null!;
        public required DbSet<ExerciseMuscleGroup> ExercisesMuscleGroups { get; set; } = null!;
        public required DbSet<Exercise> Exercises { get; set; } = null!;
        public required DbSet<ExercisePerformInfo> ExercisesPerformInfos { get; set; } = null!;
        public required DbSet<ExercisePerformInfoSingleWorkout> ExercisePerformInfosSingleWorkouts { get; set; } = null!;
        public required DbSet<SingleWorkout> SingleWorkouts { get; set; } = null!;
        public required DbSet<SingleWorkoutWorkoutPlan> SingleWorkoutsWorkoutPlans { get; set; } = null!;
        public required DbSet<WorkoutPlan> WorkoutPlans { get; set; } = null!;
        public required DbSet<SkillLevel> SkillLevels { get; set; } = null!;
        public required DbSet<Goal> Goals { get; set; } = null!;
        public required DbSet<BodyMassIndexMeasure> BodyMassIndexMeasures { get; set; } = null!;
        public required DbSet<WorkoutPlanBodyMassIndexMeasure> WorkoutPlansBodyMassIndexMeasures { get; set; } = null!;
    }
}
