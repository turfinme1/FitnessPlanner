using FitnessPlanner.Data.Models;
using FitnessPlanner.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class SingleWorkoutConfiguration : IEntityTypeConfiguration<SingleWorkout>
    {
        public void Configure(EntityTypeBuilder<SingleWorkout> builder)
        {
            builder.HasData(GetSingleWorkouts());
        }

        private SingleWorkout[] GetSingleWorkouts()
        {
            return [
                //workout plan 1 - beginner muscle gain full body workout
                new SingleWorkout()
                {
                    Id = 1,
                    Name = "Full Body type A",
                    Day = DaysOfWeek.Monday,
                },
                new SingleWorkout()
                {
                    Id = 2,
                    Name = "Full Body type B",
                    Day = DaysOfWeek.Wednesday,
                },
                new SingleWorkout()
                {
                    Id = 3,
                    Name = "Full Body type A",
                    Day = DaysOfWeek.Friday,
                },

                //workout plan 2 - beginner lose fat for women
                new SingleWorkout
                {
                    Id = 4,
                    Name = "Full Body Strength Training",
                    Day = DaysOfWeek.Monday
                },
                new SingleWorkout
                {
                    Id = 5,
                    Name = "Cardio and Core",
                    Day = DaysOfWeek.Tuesday
                },
                new SingleWorkout
                {
                    Id = 6,
                    Name = "Full Body Strength Training",
                    Day = DaysOfWeek.Thursday
                },
                new SingleWorkout
                {
                    Id = 7,
                    Name = "Cardio and Core",
                    Day = DaysOfWeek.Friday
                },

                //workout plan 3 - 
                new SingleWorkout
                {
                    Id = 8,
                    Name = "Pull",
                    Day = DaysOfWeek.Monday
                },
                new SingleWorkout
                {
                    Id = 9,
                    Name = "Push",
                    Day = DaysOfWeek.Wednesday
                },
                new SingleWorkout
                {
                    Id = 10,
                    Name = "Legs",
                    Day = DaysOfWeek.Friday
                },

                //workout plan 4 -
                new SingleWorkout
                {
                    Id = 11,
                    Name = "Push",
                    Day = DaysOfWeek.Monday
                },
                new SingleWorkout
                {
                    Id = 12,
                    Name = "Pull",
                    Day = DaysOfWeek.Tuesday
                },
                new SingleWorkout
                {
                    Id = 13,
                    Name = "Legs",
                    Day = DaysOfWeek.Wednesday
                },
                new SingleWorkout
                {
                    Id = 14,
                    Name = "Push",
                    Day = DaysOfWeek.Friday
                },
                new SingleWorkout
                {
                    Id = 15,
                    Name = "Pull",
                    Day = DaysOfWeek.Saturday
                },
                new SingleWorkout
                {
                    Id = 16,
                    Name = "Leg",
                    Day = DaysOfWeek.Sunday
                },

                //workout plan 5 -
                new SingleWorkout
                {
                    Id = 17,
                    Name = "Full Body A",
                    Day = DaysOfWeek.Monday
                },
                new SingleWorkout
                {
                    Id = 18,
                    Name = "Full Body B",
                    Day = DaysOfWeek.Wednesday
                },
                new SingleWorkout
                {
                    Id = 19,
                    Name = "Full Body C",
                    Day = DaysOfWeek.Friday
                }
            ];
        }
    }
}
