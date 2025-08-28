using Ardalis.Result;

namespace FitnessPlanner.Services.FilePersistence.Contracts
{
    public interface IFilePersistenceService
    {
        Task<Result> AddFileAsync(Stream fileStream, string fileName);
    }
}
