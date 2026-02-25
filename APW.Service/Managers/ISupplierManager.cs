using APW.Models;

namespace APW.Service.Managers;

public interface ISupplierManager
{
    Task<List<Supplier>> ReadAllAsync();
    Task<Supplier?> GetByIdAsync(int id);
    Task<Supplier> CreateAsync(Supplier entity);
    Task<bool> UpdateAsync(Supplier entity);
    Task<bool> DeleteAsync(int id);
}