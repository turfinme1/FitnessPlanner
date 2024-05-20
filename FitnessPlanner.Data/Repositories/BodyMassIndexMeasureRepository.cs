using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class BodyMassIndexMeasureRepository(ApplicationDbContext context) : Repository<BodyMassIndexMeasure>(context), IBodyMassIndexMeasureRepository
    {
    }
}
