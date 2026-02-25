using APW.Models;
using APW.Repositories;

namespace APW.Service.Managers;

public class UserRoleManager : IUserRoleManager
{
    private readonly IUserRoleRepository _repo;

    public UserRoleManager(IUserRoleRepository repo)
    {
        _repo = repo;
    }

    public Task<List<UserRole>> ReadAllAsync() => _repo.ReadAllAsync();
    public Task<UserRole?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
    public Task<UserRole> CreateAsync(UserRole entity) => _repo.CreateAsync(entity);
    public Task<bool> UpdateAsync(UserRole entity) => _repo.UpdateAsync(entity);
    public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);
}