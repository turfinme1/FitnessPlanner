using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class SingleWorkoutWorkoutPlanConfiguration : IEntityTypeConfiguration<SingleWorkoutWorkoutPlan>
    {
        public void Configure(EntityTypeBuilder<SingleWorkoutWorkoutPlan> builder)
        {
            builder.HasData(GetSingleWorkoutWorkoutPlans());
        }

        private SingleWorkoutWorkoutPlan[] GetSingleWorkoutWorkoutPlans()
        {
            return
            [
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 1,
                    SingleWorkoutId = 1,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 1,
                    SingleWorkoutId = 2,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 1,
                    SingleWorkoutId = 3,
                }
            ];
        }
    }
}
