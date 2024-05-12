using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class WorkoutPlanBodyMassIndexMeasureConfiguration : IEntityTypeConfiguration<WorkoutPlanBodyMassIndexMeasure>
    {
        public void Configure(EntityTypeBuilder<WorkoutPlanBodyMassIndexMeasure> builder)
        {
            builder.HasData(GetWorkoutPlanBodyMassIndexMeasures());
        }

        private static WorkoutPlanBodyMassIndexMeasure[] GetWorkoutPlanBodyMassIndexMeasures()
        {
            return
            [
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 1, BodyMassIndexMeasureId = 2 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 1, BodyMassIndexMeasureId = 3 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 1, BodyMassIndexMeasureId = 4 },
            ];
        }
    }
}
