using APW.Data;
using APW.Models;
using Microsoft.EntityFrameworkCore;
using PAW3.Data.Repositories;
using System.Threading.Tasks;

namespace APW.Data.Repositories;

public interface ICategoryRepository 
{
    Task<bool> UpsertAsync(Category entity, bool isUpdating);
    Task<bool> CreateAsync(Category entity);
    Task<bool> DeleteAsync(Category entity);
    Task<IEnumerable<Category>> ReadAsync();
    Task<Category> FindAsync(int id);
    Task<bool> UpdateAsync(Category entity);
    Task<bool> UpdateManyAsync(IEnumerable<Category> entities);
    Task<bool> ExistsAsync(Category entity);
}

public class CategoryRepository(ProductDbContext context) : RepositoryBase<Category>(context), ICategoryRepository
{
}


