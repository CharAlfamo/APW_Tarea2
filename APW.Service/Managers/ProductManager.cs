using APW.Models;
using APW.Repositories;

namespace APW.Service.Managers;

public class ProductManager : IProductManager
{
    private readonly IProductRepository _repo;

    public ProductManager(IProductRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Product>> ReadAllAsync() => _repo.ReadAllAsync();
    public Task<Product?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
    public Task<Product> CreateAsync(Product entity) => _repo.CreateAsync(entity);
    public Task<bool> UpdateAsync(Product entity) => _repo.UpdateAsync(entity);
    public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);
}