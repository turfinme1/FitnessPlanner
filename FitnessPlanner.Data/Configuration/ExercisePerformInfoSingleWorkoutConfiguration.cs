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

                //workout plan 2 
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 4, ExercisePerformInfoId = 8 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 4, ExercisePerformInfoId = 9 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 4, ExercisePerformInfoId = 10 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 4, ExercisePerformInfoId = 11 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 4, ExercisePerformInfoId = 12 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 4, ExercisePerformInfoId = 13 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 4, ExercisePerformInfoId = 14 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 5, ExercisePerformInfoId = 15 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 5, ExercisePerformInfoId = 16 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 5, ExercisePerformInfoId = 17 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 5, ExercisePerformInfoId = 18 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 5, ExercisePerformInfoId = 19 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 5, ExercisePerformInfoId = 20 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 6, ExercisePerformInfoId = 8 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 6, ExercisePerformInfoId = 9 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 6, ExercisePerformInfoId = 10 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 6, ExercisePerformInfoId = 11 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 6, ExercisePerformInfoId = 12 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 6, ExercisePerformInfoId = 13 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 7, ExercisePerformInfoId = 15 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 7, ExercisePerformInfoId = 16 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 7, ExercisePerformInfoId = 17 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 7, ExercisePerformInfoId = 18 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 7, ExercisePerformInfoId = 19 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 7, ExercisePerformInfoId = 20 },

            ];
        }
    }
}
