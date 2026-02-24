using APW.Models;

namespace APW.Service.Managers;

public interface ICategoryManager
{
    Task<List<Category>> ReadAllAsync();
    Task<Category?> GetByIdAsync(int id);
    Task<Category> CreateAsync(Category entity);
    Task<bool> UpdateAsync(Category entity);
    Task<bool> DeleteAsync(int id);
}