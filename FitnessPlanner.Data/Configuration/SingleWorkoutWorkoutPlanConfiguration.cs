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

                //workout plan 3 - push pull legs workout for intermediate lifters
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 3,
                    SingleWorkoutId = 8,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 3,
                    SingleWorkoutId = 9,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 3,
                    SingleWorkoutId = 10,
                },

                //workout plan 4 - push pull legs workout for advanced lifters
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 4,
                    SingleWorkoutId = 11,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 4,
                    SingleWorkoutId = 12,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 4,
                    SingleWorkoutId = 13,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 4,
                    SingleWorkoutId = 14,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 4,
                    SingleWorkoutId = 15,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 4,
                    SingleWorkoutId = 16,
                },

                //workout plan 5 - beginner weight loss plan
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 5,
                    SingleWorkoutId = 17,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 5,
                    SingleWorkoutId = 18,
                },
                new SingleWorkoutWorkoutPlan()
                {
                    WorkoutPlanId = 5,
                    SingleWorkoutId = 19,
                },

            ];
        }
    }
}
