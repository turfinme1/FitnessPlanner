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
            ];
        }
    }
}
