using System.Linq.Expressions;

namespace HciMedico.Integration.Data.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity?> GetByIdAsync(int id, bool asReadOnly = false, string? propertiesToInclude = null);

    Task<List<TEntity>> GetAllAsync(
        Expression<Func<TEntity, bool>>? filter = null, bool asReadOnly = false, string? propertiesToInclude = null);

    Task<TEntity?> FindAsync(
        Expression<Func<TEntity, bool>>? filter = null, bool asReadOnly = false, string? propertiesToInclude = null);

    Task Add(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(TEntity entity);
}
