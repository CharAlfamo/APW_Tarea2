using APW.Data;
using APW.Models;
using Microsoft.EntityFrameworkCore;
using PAW3.Data.Repositories;
using System.Threading.Tasks;

namespace APW.Data.Repositories;

public interface IInventoryRepository
{ 
    Task<bool> UpsertAsync(Inventory entity, bool isUpdating);
    Task<bool> CreateAsync(Inventory entity);
    Task<bool> DeleteAsync(Inventory entity);
    Task<IEnumerable<Inventory>> ReadAsync();
    Task<Inventory> FindAsync(int id);
    Task<bool> UpdateAsync(Inventory entity);
    Task<bool> UpdateManyAsync(IEnumerable<Inventory> entities);
    Task<bool> ExistsAsync(Inventory entity);
}


public class InventoryRepository(ProductDbContext context) : RepositoryBase<Inventory>(context), IInventoryRepository
{
}


