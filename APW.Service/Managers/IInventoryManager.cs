using APW.Models;

namespace APW.Service.Managers;

public interface IInventoryManager
{
    Task<List<Inventory>> ReadAllAsync();
    Task<Inventory?> GetByIdAsync(int id);
    Task<Inventory> CreateAsync(Inventory entity);
    Task<bool> UpdateAsync(Inventory entity);
    Task<bool> DeleteAsync(int id);
}