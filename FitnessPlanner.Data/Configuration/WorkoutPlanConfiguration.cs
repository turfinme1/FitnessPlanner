using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class WorkoutPlanConfiguration : IEntityTypeConfiguration<WorkoutPlan>
    {
        public void Configure(EntityTypeBuilder<WorkoutPlan> builder)
        {
            builder.HasData(GetWorkoutPlans());
        }

        private WorkoutPlan[] GetWorkoutPlans()
        {
            return
            [
                new WorkoutPlan()
                {
                    Id = 1,
                    Name = "Beginner muscle gain full body workout",
                    GoalId = 1,
                    SkillLevelId = 1,
                },
                new WorkoutPlan()
                {
                    Id = 2,
                    Name = "Beginner body toning workout for women",
                    GoalId = 1,
                    SkillLevelId = 1,
                },
            ];
        }
    }
}
