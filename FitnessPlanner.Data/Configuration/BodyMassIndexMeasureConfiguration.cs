using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessPlanner.Data.Configuration
{
    public class BodyMassIndexMeasureConfiguration : IEntityTypeConfiguration<BodyMassIndexMeasure>
    {
        public void Configure(EntityTypeBuilder<BodyMassIndexMeasure> builder)
        {
            builder.HasData(GetBodyMassIndexMeasures());
        }

        private static BodyMassIndexMeasure[] GetBodyMassIndexMeasures()
        {
            return
            [
                new BodyMassIndexMeasure { Id = 1, Type = "Severe Underweight" },
                new BodyMassIndexMeasure { Id = 2, Type = "Underweight" },
                new BodyMassIndexMeasure { Id = 3, Type = "Normal weight" },
                new BodyMassIndexMeasure { Id = 4, Type = "Slightly Above Normal weight" },
                new BodyMassIndexMeasure { Id = 5, Type = "Overweight" },
                new BodyMassIndexMeasure { Id = 6, Type = "Obesity" }
            ];
        }
    }
}
