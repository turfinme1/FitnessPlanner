using Ardalis.Result;
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

        public async Task<Result> AddFileAsync(Stream fileStream, string fileName)
        {
            var blobClient = _containerClient.GetBlobClient(fileName);

            try
            {
                await blobClient.UploadAsync(fileStream, overwrite: true);
                return Result.Success();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(AddFileAsync)}");
                return Result.Error("Could not upload file");
            }
        }
    }
}
