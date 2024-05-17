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
                }
            ];
        }
    }
}
