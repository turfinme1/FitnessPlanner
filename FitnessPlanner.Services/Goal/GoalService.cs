using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Services.Goal.Contracts;
using FitnessPlanner.Services.Models.Goal;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.Goal
{
    public sealed class GoalService(
        IUnitOfWork repositoryManager,
        ILogger<GoalService> logger) : IGoalService
    {
        public async Task<IEnumerable<string>> GetAllNamesAsync()
        {
            try
            {
                return (await repositoryManager.Goals.GetAllAsync()).Select(g => g.Name);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllNamesAsync)}");
                throw;
            }
        }
    }
}
