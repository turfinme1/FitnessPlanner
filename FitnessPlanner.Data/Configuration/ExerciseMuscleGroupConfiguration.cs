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
                new ExerciseMuscleGroup() { ExerciseId = 1, MuscleGroupId = 1 },
                new ExerciseMuscleGroup() { ExerciseId = 2, MuscleGroupId = 1 },
                new ExerciseMuscleGroup() { ExerciseId = 3, MuscleGroupId = 1 },
                new ExerciseMuscleGroup() { ExerciseId = 4, MuscleGroupId = 1 },

                new ExerciseMuscleGroup() { ExerciseId = 5, MuscleGroupId = 2 },
                new ExerciseMuscleGroup() { ExerciseId = 6, MuscleGroupId = 2 },
                new ExerciseMuscleGroup() { ExerciseId = 7, MuscleGroupId = 2 },

                new ExerciseMuscleGroup() { ExerciseId = 8, MuscleGroupId = 3 },
                new ExerciseMuscleGroup() { ExerciseId = 9, MuscleGroupId = 3 },
                new ExerciseMuscleGroup() { ExerciseId = 10, MuscleGroupId = 3 },
                new ExerciseMuscleGroup() { ExerciseId = 11, MuscleGroupId = 3 },
                new ExerciseMuscleGroup() { ExerciseId = 12, MuscleGroupId = 3 },
                new ExerciseMuscleGroup() { ExerciseId = 13, MuscleGroupId = 3 },
                new ExerciseMuscleGroup() { ExerciseId = 14, MuscleGroupId = 3 },
                new ExerciseMuscleGroup() { ExerciseId = 15, MuscleGroupId = 3 },
                new ExerciseMuscleGroup() { ExerciseId = 16, MuscleGroupId = 3 },
                new ExerciseMuscleGroup() { ExerciseId = 17, MuscleGroupId = 3 },

                new ExerciseMuscleGroup() { ExerciseId = 18, MuscleGroupId = 4 },
                new ExerciseMuscleGroup() { ExerciseId = 19, MuscleGroupId = 4 },
                new ExerciseMuscleGroup() { ExerciseId = 20, MuscleGroupId = 4 },
                new ExerciseMuscleGroup() { ExerciseId = 21, MuscleGroupId = 4 },
                new ExerciseMuscleGroup() { ExerciseId = 22, MuscleGroupId = 4 },
                new ExerciseMuscleGroup() { ExerciseId = 23, MuscleGroupId = 4 },
                new ExerciseMuscleGroup() { ExerciseId = 24, MuscleGroupId = 4 },
                new ExerciseMuscleGroup() { ExerciseId = 25, MuscleGroupId = 4 },
                new ExerciseMuscleGroup() { ExerciseId = 26, MuscleGroupId = 4 },
                new ExerciseMuscleGroup() { ExerciseId = 27, MuscleGroupId = 4 },

                new ExerciseMuscleGroup() { ExerciseId = 28, MuscleGroupId = 5 },
                new ExerciseMuscleGroup() { ExerciseId = 29, MuscleGroupId = 5 },
                new ExerciseMuscleGroup() { ExerciseId = 30, MuscleGroupId = 5 },
                new ExerciseMuscleGroup() { ExerciseId = 31, MuscleGroupId = 5 },
                new ExerciseMuscleGroup() { ExerciseId = 32, MuscleGroupId = 5 },
                new ExerciseMuscleGroup() { ExerciseId = 33, MuscleGroupId = 5 },
                new ExerciseMuscleGroup() { ExerciseId = 34, MuscleGroupId = 5 },
                new ExerciseMuscleGroup() { ExerciseId = 35, MuscleGroupId = 5 },
                new ExerciseMuscleGroup() { ExerciseId = 36, MuscleGroupId = 5 },
                new ExerciseMuscleGroup() { ExerciseId = 37, MuscleGroupId = 5 },

                new ExerciseMuscleGroup() { ExerciseId = 38, MuscleGroupId = 6 },
                new ExerciseMuscleGroup() { ExerciseId = 39, MuscleGroupId = 6 },
                new ExerciseMuscleGroup() { ExerciseId = 40, MuscleGroupId = 6 },
                new ExerciseMuscleGroup() { ExerciseId = 41, MuscleGroupId = 6 },
                new ExerciseMuscleGroup() { ExerciseId = 42, MuscleGroupId = 6 },
                new ExerciseMuscleGroup() { ExerciseId = 43, MuscleGroupId = 6 },
                new ExerciseMuscleGroup() { ExerciseId = 44, MuscleGroupId = 6 },
                new ExerciseMuscleGroup() { ExerciseId = 45, MuscleGroupId = 6 },
                new ExerciseMuscleGroup() { ExerciseId = 46, MuscleGroupId = 6 },
                new ExerciseMuscleGroup() { ExerciseId = 47, MuscleGroupId = 6 },

                new ExerciseMuscleGroup() { ExerciseId = 48, MuscleGroupId = 7 },
                new ExerciseMuscleGroup() { ExerciseId = 49, MuscleGroupId = 7 },
                new ExerciseMuscleGroup() { ExerciseId = 50, MuscleGroupId = 7 },
                new ExerciseMuscleGroup() { ExerciseId = 51, MuscleGroupId = 7 },
                new ExerciseMuscleGroup() { ExerciseId = 52, MuscleGroupId = 7 },
                new ExerciseMuscleGroup() { ExerciseId = 53, MuscleGroupId = 7 },
                new ExerciseMuscleGroup() { ExerciseId = 54, MuscleGroupId = 7 },
                new ExerciseMuscleGroup() { ExerciseId = 55, MuscleGroupId = 7 },
                new ExerciseMuscleGroup() { ExerciseId = 56, MuscleGroupId = 7 },
                new ExerciseMuscleGroup() { ExerciseId = 57, MuscleGroupId = 7 },

                new ExerciseMuscleGroup() { ExerciseId = 58, MuscleGroupId = 8 },
                new ExerciseMuscleGroup() { ExerciseId = 59, MuscleGroupId = 8 },
                new ExerciseMuscleGroup() { ExerciseId = 60, MuscleGroupId = 8 },
                new ExerciseMuscleGroup() { ExerciseId = 61, MuscleGroupId = 8 },
                new ExerciseMuscleGroup() { ExerciseId = 62, MuscleGroupId = 8 },

                new ExerciseMuscleGroup() { ExerciseId = 63, MuscleGroupId = 9 },
                new ExerciseMuscleGroup() { ExerciseId = 64, MuscleGroupId = 9 },
                new ExerciseMuscleGroup() { ExerciseId = 65, MuscleGroupId = 9 },
                new ExerciseMuscleGroup() { ExerciseId = 66, MuscleGroupId = 9 },
                new ExerciseMuscleGroup() { ExerciseId = 67, MuscleGroupId = 9 },
                new ExerciseMuscleGroup() { ExerciseId = 68, MuscleGroupId = 9 },
                new ExerciseMuscleGroup() { ExerciseId = 69, MuscleGroupId = 9 },
                new ExerciseMuscleGroup() { ExerciseId = 70, MuscleGroupId = 9 },
                new ExerciseMuscleGroup() { ExerciseId = 71, MuscleGroupId = 9 },
                new ExerciseMuscleGroup() { ExerciseId = 72, MuscleGroupId = 9 },

                new ExerciseMuscleGroup() { ExerciseId = 73, MuscleGroupId = 10 },
                new ExerciseMuscleGroup() { ExerciseId = 74, MuscleGroupId = 10 },
                new ExerciseMuscleGroup() { ExerciseId = 75, MuscleGroupId = 10 },
                new ExerciseMuscleGroup() { ExerciseId = 76, MuscleGroupId = 10 },
                new ExerciseMuscleGroup() { ExerciseId = 77, MuscleGroupId = 10 },
                new ExerciseMuscleGroup() { ExerciseId = 78, MuscleGroupId = 10 },
                new ExerciseMuscleGroup() { ExerciseId = 79, MuscleGroupId = 10 },
                new ExerciseMuscleGroup() { ExerciseId = 80, MuscleGroupId = 10 },
                new ExerciseMuscleGroup() { ExerciseId = 81, MuscleGroupId = 10 },
                new ExerciseMuscleGroup() { ExerciseId = 82, MuscleGroupId = 10 },

                new ExerciseMuscleGroup() { ExerciseId = 83, MuscleGroupId = 11 },
                new ExerciseMuscleGroup() { ExerciseId = 84, MuscleGroupId = 11 },

                new ExerciseMuscleGroup() { ExerciseId = 85, MuscleGroupId = 12 },
                new ExerciseMuscleGroup() { ExerciseId = 86, MuscleGroupId = 12 },
                new ExerciseMuscleGroup() { ExerciseId = 87, MuscleGroupId = 12 },
                new ExerciseMuscleGroup() { ExerciseId = 88, MuscleGroupId = 12 },
                new ExerciseMuscleGroup() { ExerciseId = 89, MuscleGroupId = 12 },
            ];
        }
    }
}
