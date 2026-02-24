namespace APW.Repositories;

public interface IBaseRepository<T> where T : class
{
    Task<List<T>> ReadAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> CreateAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteAsync(int id);
}