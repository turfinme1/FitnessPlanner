
using System.Linq.Expressions;

namespace FitnessPlanner.Data.Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(bool isTracked = false);

        Task<IEnumerable<TEntity>> GetAllFilteredAsync(Expression<Func<TEntity, bool>> filter);

        Task<TEntity?> GetByIdAsync(object id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
