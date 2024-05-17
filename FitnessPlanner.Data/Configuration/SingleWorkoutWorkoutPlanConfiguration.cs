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
                //workout plan 1 - beginner muscle gain full body workout
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
                },

                //workout plan 2 - beginner lose fat for women
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 2,
                    SingleWorkoutId = 4,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 2,
                    SingleWorkoutId = 5,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 2,
                    SingleWorkoutId = 6,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 2,
                    SingleWorkoutId = 7,
                },
            ];
        }
    }
}
