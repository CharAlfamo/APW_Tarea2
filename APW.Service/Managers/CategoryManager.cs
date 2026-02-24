using APW.Models;
using APW.Repositories;

namespace APW.Service.Managers;

public class CategoryManager : ICategoryManager
{
    private readonly ICategoryRepository _repo;

    public CategoryManager(ICategoryRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Category>> ReadAllAsync() => _repo.ReadAllAsync();
    public Task<Category?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
    public Task<Category> CreateAsync(Category entity) => _repo.CreateAsync(entity);
    public Task<bool> UpdateAsync(Category entity) => _repo.UpdateAsync(entity);
    public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);
}