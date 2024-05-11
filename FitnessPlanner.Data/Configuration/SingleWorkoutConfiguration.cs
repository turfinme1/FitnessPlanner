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
            ];
        }
    }
}
