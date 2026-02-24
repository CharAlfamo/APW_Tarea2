using APW.Data;
using APW.Models;
using Microsoft.EntityFrameworkCore;
using PAW3.Data.Repositories;
using System.Threading.Tasks;

namespace APW.Data.Repositories;
public interface ISupplierRepository
{
    Task<bool> UpsertAsync(Supplier entity, bool isUpdating);
    Task<bool> CreateAsync(Supplier entity);
    Task<bool> DeleteAsync(Supplier entity);
    Task<IEnumerable<Supplier>> ReadAsync();
    Task<Supplier> FindAsync(int id);
    Task<bool> UpdateAsync(Supplier entity);
    Task<bool> UpdateManyAsync(IEnumerable<Supplier> entities);
    Task<bool> ExistsAsync(Supplier entity);
}

public class SupplierRepository(ProductDbContext context) : RepositoryBase<Supplier>(context), ISupplierRepository
{

}