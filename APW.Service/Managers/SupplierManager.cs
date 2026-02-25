using APW.Models;
using APW.Repositories;

namespace APW.Service.Managers;

public class SupplierManager : ISupplierManager
{
    private readonly ISupplierRepository _repo;

    public SupplierManager(ISupplierRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Supplier>> ReadAllAsync() => _repo.ReadAllAsync();
    public Task<Supplier?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
    public Task<Supplier> CreateAsync(Supplier entity) => _repo.CreateAsync(entity);
    public Task<bool> UpdateAsync(Supplier entity) => _repo.UpdateAsync(entity);
    public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);
}