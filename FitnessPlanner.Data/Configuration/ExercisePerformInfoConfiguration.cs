using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class ExercisePerformInfoConfiguration : IEntityTypeConfiguration<ExercisePerformInfo>
    {
        public void Configure(EntityTypeBuilder<ExercisePerformInfo> builder)
        {
            builder.HasData(GetExercisePerformInfos());
        }

        private ExercisePerformInfo[] GetExercisePerformInfos()
        {
            return [
                // squat
                new ExercisePerformInfo()
                {
                    Id = 1,
                    ExerciseId = 73,
                    Sets = 3,
                    Reps = 5
                },

                // bench press
                new ExercisePerformInfo()
                {
                    Id = 2,
                    ExerciseId = 18,
                    Sets = 3,
                    Reps = 5
                },

                // barbel bent over row
                new ExercisePerformInfo()
                {
                    Id = 3,
                    ExerciseId = 86,
                    Sets = 3,
                    Reps = 5
                },

                // dips
                new ExercisePerformInfo()
                {
                    Id = 4,
                    ExerciseId = 50,
                    Sets = 3,
                    Reps = 5
                },

                // Barbell Military Press
                new ExercisePerformInfo()
                {
                    Id = 5,
                    ExerciseId = 8,
                    Sets = 3,
                    Reps = 5
                },

                // bench dips
                new ExercisePerformInfo()
                {
                    Id = 6,
                    ExerciseId = 57,
                    Sets = 3,
                    Reps = 5
                },

                //preacher curl
                new ExercisePerformInfo()
                {
                    Id = 7,
                    ExerciseId = 38,
                    Sets = 3,
                    Reps = 5
                },

                // workout 2
                new ExercisePerformInfo { Id = 8, ExerciseId = 73, Sets = 3, Reps = 12 }, // Barbell Squat
                new ExercisePerformInfo { Id = 9, ExerciseId = 9, Sets = 3, Reps = 12 }, // Dumbbell Shoulder Press
                new ExercisePerformInfo { Id = 10, ExerciseId = 32, Sets = 3, Reps = 12 }, // Lat Pulldown
                new ExercisePerformInfo { Id = 11, ExerciseId = 43, Sets = 3, Reps = 12 }, // Incline Dumbbell Curl
                new ExercisePerformInfo { Id = 12, ExerciseId = 30, Sets = 3, Reps = 12 }, // Dumbbell Row
                new ExercisePerformInfo { Id = 13, ExerciseId = 77, Sets = 3, Reps = 12 }, // Seated Leg Curl
                new ExercisePerformInfo { Id = 14, ExerciseId = 83, Sets = 3, Reps = 15 }, // Leg Press Calf Raise
                new ExercisePerformInfo { Id = 15, ExerciseId = 81, Sets = 3, Reps = 15 }, // Jump Squats
                new ExercisePerformInfo { Id = 16, ExerciseId = 85, Sets = 3, Reps = 30 }, // Battle Rope (seconds)
                new ExercisePerformInfo { Id = 17, ExerciseId = 66, Sets = 3, Reps = 30 }, // Plank (seconds)
                new ExercisePerformInfo { Id = 18, ExerciseId = 68, Sets = 3, Reps = 15 }, // Leg Scissors
                new ExercisePerformInfo { Id = 19, ExerciseId = 70, Sets = 3, Reps = 12 }, // Swiss Ball Rollout
                new ExercisePerformInfo { Id = 20, ExerciseId = 72, Sets = 3, Reps = 10 } // Hanging Side Knee Raises

            ];
        }
    }
}
