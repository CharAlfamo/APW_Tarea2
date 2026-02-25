using APW.Models;

namespace APW.Service.Managers;

public interface IUserRoleManager
{
    Task<List<UserRole>> ReadAllAsync();
    Task<UserRole?> GetByIdAsync(int id);
    Task<UserRole> CreateAsync(UserRole entity);
    Task<bool> UpdateAsync(UserRole entity);
    Task<bool> DeleteAsync(int id);
}