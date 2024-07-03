using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class SkillLevelConfiguration : IEntityTypeConfiguration<SkillLevel>
    {
        public void Configure(EntityTypeBuilder<SkillLevel> builder)
        {
            builder.HasData(GetSkillLevels());
        }

        private static SkillLevel[] GetSkillLevels()
        {
            return
            [
                new SkillLevel { Id = 1, Name = "Beginner" },
                new SkillLevel { Id = 2, Name = "Intermediate" },
                new SkillLevel { Id = 3, Name = "Advanced" },
                new SkillLevel { Id = 4, Name = "Professional" }
            ];
        }
    }
}
