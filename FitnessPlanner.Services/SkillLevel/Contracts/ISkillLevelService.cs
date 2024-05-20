namespace FitnessPlanner.Services.SkillLevel.Contracts
{
    public interface ISkillLevelService
    {
        Task<IEnumerable<string>> GetAllNamesAsync();
    }
}
