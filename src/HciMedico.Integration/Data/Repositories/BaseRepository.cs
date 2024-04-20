using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HciMedico.Integration.Data.Repositories;

public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;
    protected DbSet<TEntity> _dbSet;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public virtual async Task<List<TEntity>> GetAllAsync(
        Expression<Func<TEntity, bool>>? filter = null, bool asReadOnly = false, string? propertiesToInclude = null)
    {
        var query = _dbSet.AsQueryable();

        if (asReadOnly)
            query = query.AsNoTracking();

        //if (filter is not null)
        //    query = query.Where(filter);

        if (!string.IsNullOrEmpty(propertiesToInclude))
        {
            string[] properties = propertiesToInclude.Split(",");

            foreach (string property in properties)
                query = query.Include(property.Trim());
        }

        if (filter is not null)
            query = query.Where(filter);

        return await query.ToListAsync();
    }

    public virtual async Task<TEntity?> GetByIdAsync(int id, bool asReadOnly = false, string? propertiesToInclude = null)
    {
        var query = _dbSet.AsQueryable();

        if (asReadOnly)
            query = query.AsNoTracking();

        if (!string.IsNullOrEmpty(propertiesToInclude))
        {
            string[] properties = propertiesToInclude.Split(",");

            foreach (string property in properties)
                query = query.Include(property.Trim());
        }

        var dbSet = (DbSet<TEntity>)query;

        return await dbSet.FindAsync(id);
    }

    public async Task<TEntity?> FindAsync(
        Expression<Func<TEntity, bool>>? filter = null, bool asReadOnly = false, string? propertiesToInclude = null)
    {
        var query = _dbSet.AsQueryable();

        if (asReadOnly)
            query = query.AsNoTracking();

        //if (filter is not null)
        //    query = query.Where(filter);

        if (!string.IsNullOrEmpty(propertiesToInclude))
        {
            string[] properties = propertiesToInclude.Split(",");

            foreach (string property in properties)
                query = query.Include(property.Trim());
        }

        if (filter is not null)
            query = query.Where(filter);

        return await query.FirstOrDefaultAsync();
    }

    public virtual async Task Add(TEntity entity)
    {
        _dbSet.Add(entity);
        await SaveChangesAsync();
    }

    public virtual async Task Update(TEntity entity)
    {
        _dbSet.Update(entity);
        await SaveChangesAsync();
    }

    public virtual async Task Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
        await SaveChangesAsync();
    }

    protected virtual async Task SaveChangesAsync() => await _context.SaveChangesAsync();
}