using APW.Data;
using Microsoft.EntityFrameworkCore;

namespace APW.Repositories;

public class RepositoryBase<T> : IBaseRepository<T> where T : class
{
    protected readonly ProductDbContext _db;
    protected readonly DbSet<T> _set;

    public RepositoryBase(ProductDbContext db)
    {
        _db = db;
        _set = _db.Set<T>();
    }

    public async Task<List<T>> ReadAllAsync()
        => await _set.AsNoTracking().ToListAsync();

    public async Task<T?> GetByIdAsync(int id)
        => await _set.FindAsync(id);

    public async Task<T> CreateAsync(T entity)
    {
        _set.Add(entity);
        await _db.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        _set.Update(entity);
        return await _db.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity is null) return false;

        _set.Remove(entity);
        return await _db.SaveChangesAsync() > 0;
    }
}