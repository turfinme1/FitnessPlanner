using FitnessPlanner.Data.Models.Enums;
using FitnessPlanner.Services.BodyMassIndexCalculation.Contracts;

namespace FitnessPlanner.Services.BodyMassIndexCalculation
{
    public sealed class BodyMassIndexCalculationService : IBodyMassIndexCalculationService
    {
        public int GetBodyMassIndexMeasureId(double weight, double height)
        {
            var bodyMassIndex = GetBodyMassIndex(weight, height);
            
            return bodyMassIndex switch
            {
                < 16 => (int)BodyMassIndexMeasuresEnum.SevereUnderweight,
                >= 16 and < 19 => (int) BodyMassIndexMeasuresEnum.Underweight,
                >= 19 and < 25 => (int)BodyMassIndexMeasuresEnum.NormalWeight,
                >= 25 and < 28 => (int)BodyMassIndexMeasuresEnum.SlightlyAboveNormalWeight,
                >= 28 and < 35 => (int)BodyMassIndexMeasuresEnum.Overweight,
                _ => (int)BodyMassIndexMeasuresEnum.Obesity
            };
        }

        private static double GetBodyMassIndex(double weight, double height)
        {
            var heightInMeters = height / 100;
            return weight / (heightInMeters * heightInMeters);
        }
    }
}
