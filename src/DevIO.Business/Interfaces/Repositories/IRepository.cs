using DevIO.Business.Models;
using System.Linq.Expressions;

namespace DevIO.Business.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate);
        
        Task<TEntity> GetByIdAsync(Guid id);
        
        Task<List<TEntity>> GetAllAsync();
        
        Task AddAsync(TEntity entity);
        
        Task UpdateAsync(TEntity entity);
        
        Task RemoveAsync(Guid id);
        
        Task<int> SaveChanges();
    }
}
