namespace FitnessPlanner.Services.BodyMassIndexMeasure.Contracts
{
    public interface IBodyMassIndexMeasureService
    {
        Task<IEnumerable<string>> GetAllNamesAsync();
    }
}
