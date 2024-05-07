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
            //builder.ApplyConfiguration(new ExerciseMuscleGroupConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<MuscleGroup> MuscleGroups { get; set; } = null!;
        public DbSet<ExerciseMuscleGroup> ExercisesMuscleGroups { get; set; } = null!;
        public DbSet<Exercise> Exercises { get; set; } = null!;
        public DbSet<ExercisePerformInfo> ExercisesPerformInfos { get; set; } = null!;
        public DbSet<ExercisePerformInfoSingleWorkout> ExercisePerformInfosSingleWorkouts { get; set; } = null!;
        public DbSet<SingleWorkout> SingleWorkouts { get; set; } = null!;
        public DbSet<SingleWorkoutWorkoutPlan> SingleWorkoutsWorkoutPlans { get; set; } = null!;
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; } = null!;
    }
}
