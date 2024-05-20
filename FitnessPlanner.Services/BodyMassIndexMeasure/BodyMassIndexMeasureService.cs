using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Services.BodyMassIndexMeasure.Contracts;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.BodyMassIndexMeasure
{
    public sealed class BodyMassIndexMeasureService(
        IUnitOfWork repositoryManager,
        ILogger<BodyMassIndexMeasureService> logger) : IBodyMassIndexMeasureService
    {
        public async Task<IEnumerable<string>> GetAllNamesAsync()
        {
            try
            {
                return (await repositoryManager.BodyMassIndexMeasures.GetAllAsync()).Select(b => b.Type);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllNamesAsync)}");
                throw;
            }
        }
    }
}
