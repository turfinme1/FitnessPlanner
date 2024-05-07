using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class ExerciseMuscleGroupConfiguration : IEntityTypeConfiguration<ExerciseMuscleGroup>
    {
        public void Configure(EntityTypeBuilder<ExerciseMuscleGroup> builder)
        {
            builder.HasData(GetExerciseMuscleGroups());
        }

        private static ExerciseMuscleGroup[] GetExerciseMuscleGroups()
        {
            return [
                new ExerciseMuscleGroup()
                {
                    ExerciseId = 1,
                    MuscleGroupId = 1,
                }
            ];
        }
    }
}
