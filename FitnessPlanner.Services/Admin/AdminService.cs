using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Services.Admin.Contracts;
using FitnessPlanner.Services.Models.User;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.Admin
{
    public sealed class AdminService(
        IUnitOfWork repositoryManager,
        ILogger<AdminService> logger) : IAdminService
    {
        public async Task<IEnumerable<UserDisplayDto>> GetAllUsersAsync()
        {
            try
            {
                return (await repositoryManager.Users.GetAllWithRelatedEntitiesAsync()).Select(u => new UserDisplayDto
                {
                    Id = u.Id,
                    Email = u.Email!,
                    Name = u.Name,
                    Age = u.Age,
                    Height = u.Height,
                    Weight = u.Weight,
                    Gender = u.Gender.ToString(),
                    SkillLevel = u.SkillLevel?.Name ?? string.Empty,
                    Goal = u.Goal?.Name ?? string.Empty,
                    BodyMassIndexMeasure = u.BodyMassIndexMeasure?.Type ?? string.Empty,
                });
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllUsersAsync)}");
                throw;
            }
        }
    }
}
