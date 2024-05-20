using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Services.SkillLevel.Contracts;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.SkillLevel
{
    public sealed class SkillLevelService(
        IUnitOfWork repositoryManager,
        ILogger<SkillLevelService> logger) : ISkillLevelService
    {
        public async Task<IEnumerable<string>> GetAllNamesAsync()
        {
            try
            {
                return (await repositoryManager.SkillLevels.GetAllAsync()).Select(s => s.Name);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllNamesAsync)}");
                throw;
            }
        }
    }
}
