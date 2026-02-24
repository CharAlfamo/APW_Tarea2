using APW.Models;

namespace APW.Service.Managers;

public interface IProductManager
{
    Task<List<Product>> ReadAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task<Product> CreateAsync(Product entity);
    Task<bool> UpdateAsync(Product entity);
    Task<bool> DeleteAsync(int id);
}