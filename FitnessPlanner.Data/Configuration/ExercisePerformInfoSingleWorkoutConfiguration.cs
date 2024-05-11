using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class ExercisePerformInfoSingleWorkoutConfiguration : IEntityTypeConfiguration<ExercisePerformInfoSingleWorkout>
    {
        public void Configure(EntityTypeBuilder<ExercisePerformInfoSingleWorkout> builder)
        {
            builder.HasData(GetExercisePerformInfoSingleWorkouts());
        }

        private ExercisePerformInfoSingleWorkout[] GetExercisePerformInfoSingleWorkouts()
        {
            return [
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 1,
                    ExercisePerformInfoId = 1,
                },
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 1,
                    ExercisePerformInfoId = 2,
                },
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 1,
                    ExercisePerformInfoId = 3,
                },
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 1,
                    ExercisePerformInfoId = 4,
                },

                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 2,
                    ExercisePerformInfoId = 1,
                },
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 2,
                    ExercisePerformInfoId = 5,
                },
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 2,
                    ExercisePerformInfoId = 6,
                },
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 2,
                    ExercisePerformInfoId = 7,
                },

                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 3,
                    ExercisePerformInfoId = 1,
                },
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 3,
                    ExercisePerformInfoId = 2,
                },
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 3,
                    ExercisePerformInfoId = 3,
                },
                new ExercisePerformInfoSingleWorkout()
                {
                    SingleWorkoutId = 3,
                    ExercisePerformInfoId = 4,
                },
            ];
        }
    }
}
