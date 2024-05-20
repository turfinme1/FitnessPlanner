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

                //workout plan 3
                // Pull Workout
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 8, ExercisePerformInfoId = 21 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 8, ExercisePerformInfoId = 22 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 8, ExercisePerformInfoId = 23 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 8, ExercisePerformInfoId = 24 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 8, ExercisePerformInfoId = 25 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 8, ExercisePerformInfoId = 26 },

                // Push Workout
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 9, ExercisePerformInfoId = 27 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 9, ExercisePerformInfoId = 28 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 9, ExercisePerformInfoId = 29 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 9, ExercisePerformInfoId = 30 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 9, ExercisePerformInfoId = 31 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 9, ExercisePerformInfoId = 32 },

                // Leg Workout
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 10, ExercisePerformInfoId = 33 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 10, ExercisePerformInfoId = 34 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 10, ExercisePerformInfoId = 35 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 10, ExercisePerformInfoId = 36 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 10, ExercisePerformInfoId = 37 },

                //workout plan 4
                // Advanced Push Workout
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 11, ExercisePerformInfoId = 38 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 11, ExercisePerformInfoId = 39 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 11, ExercisePerformInfoId = 40 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 11, ExercisePerformInfoId = 41 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 11, ExercisePerformInfoId = 42 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 11, ExercisePerformInfoId = 43 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 11, ExercisePerformInfoId = 44 },

                // Advanced Pull Workout
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 12, ExercisePerformInfoId = 45 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 12, ExercisePerformInfoId = 46 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 12, ExercisePerformInfoId = 47 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 12, ExercisePerformInfoId = 48 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 12, ExercisePerformInfoId = 49 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 12, ExercisePerformInfoId = 50 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 12, ExercisePerformInfoId = 51 },

                // Advanced Leg Workout
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 13, ExercisePerformInfoId = 52 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 13, ExercisePerformInfoId = 53 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 13, ExercisePerformInfoId = 54 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 13, ExercisePerformInfoId = 55 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 13, ExercisePerformInfoId = 56 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 13, ExercisePerformInfoId = 57 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 13, ExercisePerformInfoId = 58 },

                // Advanced Push Workout - repeat
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 14, ExercisePerformInfoId = 38 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 14, ExercisePerformInfoId = 39 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 14, ExercisePerformInfoId = 40 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 14, ExercisePerformInfoId = 41 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 14, ExercisePerformInfoId = 42 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 14, ExercisePerformInfoId = 43 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 14, ExercisePerformInfoId = 44 },

                // Advanced Pull Workout - repeat
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 15, ExercisePerformInfoId = 45 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 15, ExercisePerformInfoId = 46 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 15, ExercisePerformInfoId = 47 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 15, ExercisePerformInfoId = 48 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 15, ExercisePerformInfoId = 49 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 15, ExercisePerformInfoId = 50 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 15, ExercisePerformInfoId = 51 },

                // Advanced Leg Workout - repeat
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 16, ExercisePerformInfoId = 52 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 16, ExercisePerformInfoId = 53 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 16, ExercisePerformInfoId = 54 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 16, ExercisePerformInfoId = 55 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 16, ExercisePerformInfoId = 56 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 16, ExercisePerformInfoId = 57 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 16, ExercisePerformInfoId = 58 },


                //workout plan 5
                // Beginner Weight Loss - Full Body A
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 17, ExercisePerformInfoId = 59 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 17, ExercisePerformInfoId = 60 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 17, ExercisePerformInfoId = 61 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 17, ExercisePerformInfoId = 62 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 17, ExercisePerformInfoId = 63 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 17, ExercisePerformInfoId = 64 },

                // Beginner Weight Loss - Full Body B
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 18, ExercisePerformInfoId = 65 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 18, ExercisePerformInfoId = 66 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 18, ExercisePerformInfoId = 67 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 18, ExercisePerformInfoId = 68 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 18, ExercisePerformInfoId = 69 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 18, ExercisePerformInfoId = 70 },

                // Beginner Weight Loss - Full Body C
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 19, ExercisePerformInfoId = 71 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 19, ExercisePerformInfoId = 72 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 19, ExercisePerformInfoId = 73 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 19, ExercisePerformInfoId = 74 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 19, ExercisePerformInfoId = 75 },
                new ExercisePerformInfoSingleWorkout { SingleWorkoutId = 19, ExercisePerformInfoId = 76 },

            ];
        }
    }
}
