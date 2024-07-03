using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class MuscleGroupConfiguration : IEntityTypeConfiguration<MuscleGroup>
    {
        public void Configure(EntityTypeBuilder<MuscleGroup> builder)
        {
            builder.HasData(GetMuscleGroups());
        }

        private static MuscleGroup[] GetMuscleGroups()
        {
            return [
                new MuscleGroup()
                {
                    Id = 1,
                    Name = "Neck"
                },
                new MuscleGroup()
                {
                    Id = 2,
                    Name = "Trapezius"
                },
                new MuscleGroup()
                {
                    Id = 3,
                    Name = "Shoulder"
                },
                new MuscleGroup()
                {
                    Id = 4,
                    Name = "Chest"
                },
                new MuscleGroup()
                {
                    Id = 5,
                    Name = "Back"
                },
                new MuscleGroup()
                {
                    Id = 6,
                    Name = "Biceps"
                },
                new MuscleGroup()
                {
                    Id = 7,
                    Name = "Triceps"
                },
                new MuscleGroup()
                {
                    Id = 8,
                    Name = "Forearm"
                },
                new MuscleGroup()
                {
                    Id = 9,
                    Name = "Abs"
                },
                new MuscleGroup()
                {
                    Id = 10,
                    Name = "Legs"
                },
                new MuscleGroup()
                {
                    Id = 11,
                    Name = "Calves"
                },
                new MuscleGroup()
                {
                    Id = 12,
                    Name = "Full Body"
                },
            ];
        }
    }
}
