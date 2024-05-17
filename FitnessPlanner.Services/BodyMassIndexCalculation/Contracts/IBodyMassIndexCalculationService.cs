using FitnessPlanner.Data.Models.Enums;

namespace FitnessPlanner.Services.BodyMassIndexCalculation.Contracts
{
    public interface IBodyMassIndexCalculationService
    {
        BodyMassIndexMeasuresEnum GetBodyMassIndexMeasure(double weight, double height);
    }
}

