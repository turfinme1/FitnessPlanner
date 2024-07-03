using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    /// <summary>
    /// Interface for the Body Mass Index (BMI) measures repository, defining methods for managing <see cref="BodyMassIndexMeasure"/> entities.
    /// </summary>
    public interface IBodyMassIndexMeasureRepository : IRepository<BodyMassIndexMeasure>
    {
    }
}
