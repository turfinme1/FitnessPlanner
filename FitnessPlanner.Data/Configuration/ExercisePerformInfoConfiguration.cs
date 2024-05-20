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
                new ExercisePerformInfo { Id = 20, ExerciseId = 72, Sets = 3, Reps = 10 }, // Hanging Side Knee Raises


                //workout plan 3
                // Pull
                new ExercisePerformInfo { Id = 21, ExerciseId = 32, Sets = 4, Reps = 8 }, // Lat Pulldowns
                new ExercisePerformInfo { Id = 22, ExerciseId = 86, Sets = 4, Reps = 8 }, // Barbell Bent Over Row
                new ExercisePerformInfo { Id = 23, ExerciseId = 29, Sets = 4, Reps = 8 }, // Barbell Row
                new ExercisePerformInfo { Id = 24, ExerciseId = 40, Sets = 4, Reps = 8 }, // Chin Up
                new ExercisePerformInfo { Id = 25, ExerciseId = 39, Sets = 4, Reps = 12 }, // Hammer Curl
                new ExercisePerformInfo { Id = 26, ExerciseId = 42, Sets = 4, Reps = 12 }, // EZ Bar Curl

                // Push
                new ExercisePerformInfo { Id = 27, ExerciseId = 18, Sets = 4, Reps = 8 }, // Barbell Bench Press
                new ExercisePerformInfo { Id = 28, ExerciseId = 19, Sets = 4, Reps = 8 }, // Incline Barbell Bench Press
                new ExercisePerformInfo { Id = 29, ExerciseId = 8, Sets = 4, Reps = 8 }, // Barbell Military Press
                new ExercisePerformInfo { Id = 30, ExerciseId = 55, Sets = 4, Reps = 8 }, // Close Grip Bench Press
                new ExercisePerformInfo { Id = 31, ExerciseId = 5, Sets = 4, Reps = 12 }, // Dumbbell Shrug
                new ExercisePerformInfo { Id = 32, ExerciseId = 48, Sets = 4, Reps = 12 }, // Triceps Push-down

                // Leg
                new ExercisePerformInfo { Id = 33, ExerciseId = 34, Sets = 4, Reps = 8 }, // Deadlift
                new ExercisePerformInfo { Id = 34, ExerciseId = 73, Sets = 4, Reps = 8 }, // Barbell Squat
                new ExercisePerformInfo { Id = 35, ExerciseId = 75, Sets = 4, Reps = 12 }, // Hack Squats Machine
                new ExercisePerformInfo { Id = 36, ExerciseId = 76, Sets = 4, Reps = 12 }, // Leg Extension
                new ExercisePerformInfo { Id = 37, ExerciseId = 84, Sets = 4, Reps = 15 }, // Hack Squat Calf Raise


                //workout plan 4
                // Advanced Push Workout
                new ExercisePerformInfo { Id = 38, ExerciseId = 18, Sets = 4, Reps = 6 }, // Barbell Bench Press
                new ExercisePerformInfo { Id = 39, ExerciseId = 19, Sets = 4, Reps = 6 }, // Incline Barbell Bench Press
                new ExercisePerformInfo { Id = 40, ExerciseId = 8, Sets = 4, Reps = 6 }, // Barbell Military Press
                new ExercisePerformInfo { Id = 41, ExerciseId = 23, Sets = 4, Reps = 8 }, // Dumbbell Press
                new ExercisePerformInfo { Id = 42, ExerciseId = 9, Sets = 4, Reps = 8 }, // Dumbbell Shoulder Press
                new ExercisePerformInfo { Id = 43, ExerciseId = 10, Sets = 4, Reps = 10 }, // Seated Lateral Raise
                new ExercisePerformInfo { Id = 44, ExerciseId = 5, Sets = 4, Reps = 10 }, // Dumbbell Shrug

                // Advanced Pull Workout
                new ExercisePerformInfo { Id = 45, ExerciseId = 29, Sets = 4, Reps = 6 }, // Barbell Row
                new ExercisePerformInfo { Id = 46, ExerciseId = 32, Sets = 4, Reps = 6 }, // Lat Pulldowns
                new ExercisePerformInfo { Id = 47, ExerciseId = 86, Sets = 4, Reps = 6 }, // Barbell Bent Over Row
                new ExercisePerformInfo { Id = 48, ExerciseId = 30, Sets = 4, Reps = 8 }, // Dumbbell Row
                new ExercisePerformInfo { Id = 49, ExerciseId = 14, Sets = 4, Reps = 10 }, // Rope High Cable Row
                new ExercisePerformInfo { Id = 50, ExerciseId = 48, Sets = 4, Reps = 10 }, // Triceps Push-down
                new ExercisePerformInfo { Id = 51, ExerciseId = 40, Sets = 4, Reps = 8 }, // Chin Up

                // Advanced Leg Workout
                new ExercisePerformInfo { Id = 52, ExerciseId = 73, Sets = 4, Reps = 6 }, // Barbell Squat
                new ExercisePerformInfo { Id = 53, ExerciseId = 34, Sets = 4, Reps = 6 }, // Deadlift
                new ExercisePerformInfo { Id = 54, ExerciseId = 74, Sets = 4, Reps = 8 }, // Leg Press
                new ExercisePerformInfo { Id = 55, ExerciseId = 75, Sets = 4, Reps = 10 }, // Hack Squats Machine
                new ExercisePerformInfo { Id = 56, ExerciseId = 76, Sets = 4, Reps = 12 }, // Leg Extension
                new ExercisePerformInfo { Id = 57, ExerciseId = 77, Sets = 4, Reps = 12 }, // Seated Leg Curl
                new ExercisePerformInfo { Id = 58, ExerciseId = 83, Sets = 4, Reps = 15 }, // Leg Press Calf Raise


                //workout plan 5
                // Beginner Weight Loss - Full Body A
                new ExercisePerformInfo { Id = 59, ExerciseId = 24, Sets = 3, Reps = 10 }, // Push-Up
                new ExercisePerformInfo { Id = 60, ExerciseId = 32, Sets = 3, Reps = 10 }, // Lat Pulldowns
                new ExercisePerformInfo { Id = 61, ExerciseId = 9, Sets = 3, Reps = 10 }, // Dumbbell Shoulder Press
                new ExercisePerformInfo { Id = 62, ExerciseId = 73, Sets = 3, Reps = 10 }, // Barbell Squat
                new ExercisePerformInfo { Id = 63, ExerciseId = 77, Sets = 3, Reps = 15 }, // Seated Leg Curl
                new ExercisePerformInfo { Id = 64, ExerciseId = 85, Sets = 3, Reps = 30 }, // Battle Rope

                // Beginner Weight Loss - Full Body B
                new ExercisePerformInfo { Id = 65, ExerciseId = 25, Sets = 3, Reps = 10 }, // Cobra Push-Up
                new ExercisePerformInfo { Id = 66, ExerciseId = 31, Sets = 3, Reps = 10 }, // Seated Row Machine
                new ExercisePerformInfo { Id = 67, ExerciseId = 23, Sets = 3, Reps = 10 }, // Dumbbell Press
                new ExercisePerformInfo { Id = 68, ExerciseId = 74, Sets = 3, Reps = 10 }, // Leg Press
                new ExercisePerformInfo { Id = 69, ExerciseId = 76, Sets = 3, Reps = 15 }, // Leg Extension
                new ExercisePerformInfo { Id = 70, ExerciseId = 17, Sets = 3, Reps = 15 }, // Face Pull

                // Beginner Weight Loss - Full Body C
                new ExercisePerformInfo { Id = 71, ExerciseId = 20, Sets = 3, Reps = 10 }, // Chest Dips (use assisted machine if needed)
                new ExercisePerformInfo { Id = 72, ExerciseId = 29, Sets = 3, Reps = 10 }, // Barbell Row
                new ExercisePerformInfo { Id = 73, ExerciseId = 10, Sets = 3, Reps = 15 }, // Seated Lateral Raise
                new ExercisePerformInfo { Id = 74, ExerciseId = 82, Sets = 3, Reps = 12 }, // Static Lunge
                new ExercisePerformInfo { Id = 75, ExerciseId = 83, Sets = 3, Reps = 15 }, // Leg Press Calf Raise
                new ExercisePerformInfo { Id = 76, ExerciseId = 66, Sets = 3, Reps = 30 }, // Plank (holding for 30 seconds)

            ];
        }
    }
}
