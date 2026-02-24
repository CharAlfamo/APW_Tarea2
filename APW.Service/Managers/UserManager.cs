using APW.Models;
using APW.Repositories;

namespace APW.Service.Managers;

public class UserManager : IUserManager
{
    private readonly IUserRepository _repo;

    public UserManager(IUserRepository repo)
    {
        _repo = repo;
    }

    public Task<List<User>> ReadAllAsync() => _repo.ReadAllAsync();
    public Task<User?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
    public Task<User> CreateAsync(User entity) => _repo.CreateAsync(entity);
    public Task<bool> UpdateAsync(User entity) => _repo.UpdateAsync(entity);
    public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);
}