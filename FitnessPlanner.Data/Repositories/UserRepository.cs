using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class UserRepository(ApplicationDbContext context) : Repository<User>(context), IUserRepository
    {
        public async Task<IEnumerable<User>> GetAllWithRelatedEntitiesAsync()
        {
            return await base.DbSet
                .Include(u => u.SkillLevel)
                .Include(u => u.Goal)
                .Include(u => u.BodyMassIndexMeasure)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
