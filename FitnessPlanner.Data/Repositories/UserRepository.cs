using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class UserRepository(ApplicationDbContext context) : Repository<User>(context), IUserRepository
    {

    }
}
