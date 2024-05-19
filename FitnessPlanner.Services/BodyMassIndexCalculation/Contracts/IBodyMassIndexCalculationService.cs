using FitnessPlanner.Data.Models.Enums;

namespace FitnessPlanner.Services.BodyMassIndexCalculation.Contracts
{
    public interface IBodyMassIndexCalculationService
    {
        int GetBodyMassIndexMeasureId(double weight, double height);
    }
}

