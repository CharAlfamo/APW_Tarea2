using APW.Models;
using APW.Repositories;

namespace APW.Service.Managers;

public class RoleManager : IRoleManager
{
    private readonly IRoleRepository _repo;

    public RoleManager(IRoleRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Role>> ReadAllAsync() => _repo.ReadAllAsync();
    public Task<Role?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
    public Task<Role> CreateAsync(Role entity) => _repo.CreateAsync(entity);
    public Task<bool> UpdateAsync(Role entity) => _repo.UpdateAsync(entity);
    public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);
}