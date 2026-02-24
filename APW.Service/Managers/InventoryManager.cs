using APW.Models;
using APW.Repositories;

namespace APW.Service.Managers;

public class InventoryManager : IInventoryManager
{
    private readonly IInventoryRepository _repo;

    public InventoryManager(IInventoryRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Inventory>> ReadAllAsync() => _repo.ReadAllAsync();
    public Task<Inventory?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
    public Task<Inventory> CreateAsync(Inventory entity) => _repo.CreateAsync(entity);
    public Task<bool> UpdateAsync(Inventory entity) => _repo.UpdateAsync(entity);
    public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);
}