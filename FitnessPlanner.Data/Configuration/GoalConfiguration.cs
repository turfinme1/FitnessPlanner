using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class GoalConfiguration : IEntityTypeConfiguration<Goal>
    {
        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder.HasData(GetGoals());
        }

        private static Goal[] GetGoals()
        {
            return
            [
                new Goal { Id = 1, Name = "Lose weight" },
                new Goal { Id = 2, Name = "Gain muscle" },
                new Goal { Id = 3, Name = "Maintain weight" }
            ];
        }
    }
}
