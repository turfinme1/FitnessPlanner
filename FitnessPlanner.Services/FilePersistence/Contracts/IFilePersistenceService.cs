
namespace FitnessPlanner.Services.FilePersistence.Contracts
{
    public interface IFilePersistenceService
    {
        Task AddFileAsync(Stream fileStream, string fileName);
    }
}
