using APW.Models;

namespace APW.Service.Managers;

public interface IRoleManager
{
    Task<List<Role>> ReadAllAsync();
    Task<Role?> GetByIdAsync(int id);
    Task<Role> CreateAsync(Role entity);
    Task<bool> UpdateAsync(Role entity);
    Task<bool> DeleteAsync(int id);
}