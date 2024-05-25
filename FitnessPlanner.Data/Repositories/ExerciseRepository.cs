using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class ExerciseRepository(ApplicationDbContext context) : Repository<Exercise>(context), IExerciseRepository
    {
        public async Task<IEnumerable<Exercise>> GetAllWithRelatedEntitiesAsync()
        {
            return await base.DbSet
                .Include(e => e.ExerciseMuscleGroups)
                .ThenInclude(emg => emg.MuscleGroup)
                .ToListAsync();
        }

        public async Task<Exercise?> GetByIdWithRelatedEntitiesAsync(int id)
        {
            return await base.DbSet
                .Include(e => e.ExerciseMuscleGroups)
                .ThenInclude(emg => emg.MuscleGroup)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
