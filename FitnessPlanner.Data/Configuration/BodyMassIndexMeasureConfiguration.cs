using FitnessPlanner.Data.Models;
using FitnessPlanner.Data.Models.Enums;
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
                new BodyMassIndexMeasure { Id = (int)BodyMassIndexMeasuresEnum.SevereUnderweight, Type = "Severe Underweight" },
                new BodyMassIndexMeasure { Id = (int)BodyMassIndexMeasuresEnum.Underweight, Type = "Underweight" },
                new BodyMassIndexMeasure { Id = (int)BodyMassIndexMeasuresEnum.NormalWeight, Type = "Normal weight" },
                new BodyMassIndexMeasure { Id = (int)BodyMassIndexMeasuresEnum.SlightlyAboveNormalWeight, Type = "Slightly Above Normal weight" },
                new BodyMassIndexMeasure { Id = (int)BodyMassIndexMeasuresEnum.Overweight, Type = "Overweight" },
                new BodyMassIndexMeasure { Id = (int)BodyMassIndexMeasuresEnum.Obesity, Type = "Obesity" }
            ];
        }
    }
}
