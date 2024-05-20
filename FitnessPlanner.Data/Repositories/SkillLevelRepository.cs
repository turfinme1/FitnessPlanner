using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class SkillLevelRepository(ApplicationDbContext context) : Repository<SkillLevel>(context), ISkillLevelRepository
    {
    }
}
