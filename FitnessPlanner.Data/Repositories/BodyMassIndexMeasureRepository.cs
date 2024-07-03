using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    /// <summary>
    /// Repository class for handling data operations related to Body Mass Index (BMI) measures.
    /// </summary>
    /// <param name="context">The database context to be used by the repository.</param>
    public sealed class BodyMassIndexMeasureRepository(ApplicationDbContext context) : Repository<BodyMassIndexMeasure>(context), IBodyMassIndexMeasureRepository
    {
    }
}
