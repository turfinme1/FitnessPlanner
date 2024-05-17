using FitnessPlanner.Data.Models.Enums;
using FitnessPlanner.Services.BodyMassIndexCalculation.Contracts;

namespace FitnessPlanner.Services.BodyMassIndexCalculation
{
    public sealed class BodyMassIndexCalculationService : IBodyMassIndexCalculationService
    {
        public BodyMassIndexMeasuresEnum GetBodyMassIndexMeasure(double weight, double height)
        {   
            var bodyMassIndex = GetBodyMassIndex(weight, height);
            return bodyMassIndex switch
            {
                < 16 => BodyMassIndexMeasuresEnum.SevereUnderweight,
                >= 16 and < 19 => BodyMassIndexMeasuresEnum.Underweight,
                >= 19 and < 25 => BodyMassIndexMeasuresEnum.NormalWeight,
                >= 25 and < 28 => BodyMassIndexMeasuresEnum.SlightlyAboveNormalWeight,
                >= 28 and < 35 => BodyMassIndexMeasuresEnum.Overweight,
                _ => BodyMassIndexMeasuresEnum.Obesity
            };
        }

        private static double GetBodyMassIndex(double weight, double height)
        {
            return weight / (height * height);
        }
    }
}
