namespace FitnessPlanner.Services.Goal.Contracts
{
    public interface IGoalService
    {
        Task<IEnumerable<string>> GetAllNamesAsync();
    }
}
