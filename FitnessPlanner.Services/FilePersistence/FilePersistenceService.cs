using Azure.Storage.Blobs;
using FitnessPlanner.Services.FilePersistence.Contracts;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.FilePersistence
{
    public sealed class FilePersistenceService(
        BlobServiceClient serviceClient,
        ILogger<FilePersistenceService> logger) : IFilePersistenceService
    {
        private readonly BlobContainerClient _containerClient = serviceClient.GetBlobContainerClient("images");

        public async Task AddFileAsync(Stream fileStream, string fileName)
        {
            var blobClient = _containerClient.GetBlobClient(fileName);

            try
            {
                await blobClient.UploadAsync(fileStream, overwrite: true);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(AddFileAsync)}");
                throw;
            }
        }
    }
}
