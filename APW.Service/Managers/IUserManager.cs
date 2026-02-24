using APW.Models;

namespace APW.Service.Managers;

public interface IUserManager
{
    Task<List<User>> ReadAllAsync();
    Task<User?> GetByIdAsync(int id);
    Task<User> CreateAsync(User entity);
    Task<bool> UpdateAsync(User entity);
    Task<bool> DeleteAsync(int id);
}