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
                //workout plan 1 - beginner muscle gain full body workout
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 1, BodyMassIndexMeasureId = 2 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 1, BodyMassIndexMeasureId = 3 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 1, BodyMassIndexMeasureId = 4 },

                // workout plan 2 - beginner lose fat for women
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 2, BodyMassIndexMeasureId = 3 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 2, BodyMassIndexMeasureId = 4 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 2, BodyMassIndexMeasureId = 5 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 2, BodyMassIndexMeasureId = 6 },

                // workout plan 3 - push pull legs workout for intermediate lifters
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 3, BodyMassIndexMeasureId = 3 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 3, BodyMassIndexMeasureId = 4 },

                // workout plan 4 - push pull legs workout for advanced lifters
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 4, BodyMassIndexMeasureId = 3 },  
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 4, BodyMassIndexMeasureId = 4 },

                // workout plan 5 - beginner weight loss plan
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 5, BodyMassIndexMeasureId = 4 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 5, BodyMassIndexMeasureId = 5 },
                new WorkoutPlanBodyMassIndexMeasure { WorkoutPlanId = 5, BodyMassIndexMeasureId = 6 },
            ];
        }
    }
}
