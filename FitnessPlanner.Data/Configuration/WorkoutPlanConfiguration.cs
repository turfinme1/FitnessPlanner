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
                    Name = "Beginner muscle gain full body workout plan",
                    GoalId = 2,
                    SkillLevelId = 1,
                },
                new WorkoutPlan()
                {
                    Id = 2,
                    Name = "Beginner body toning workout plan for women",
                    GoalId = 1,
                    SkillLevelId = 1,
                },
                new WorkoutPlan()
                {
                    Id = 3,
                    Name = "Push pull legs workout plan for intermediate lifters",
                    GoalId = 2,
                    SkillLevelId = 2,
                },
                new WorkoutPlan()
                {
                    Id = 4,
                    Name = "Push pull legs workout plan for advanced lifters",
                    GoalId = 2,
                    SkillLevelId = 3,
                },
                new WorkoutPlan()
                {
                    Id = 5,
                    Name = "Beginner weight loss plan",
                    GoalId = 1,
                    SkillLevelId = 1,
                },
            ];
        }
    }
}
