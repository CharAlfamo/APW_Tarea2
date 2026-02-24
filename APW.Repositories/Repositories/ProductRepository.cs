using APW.Data;
using APW.Models;
using Microsoft.EntityFrameworkCore;
using PAW3.Data.Repositories;
using System.Threading.Tasks;

namespace APW.Data.Repositories;
    public interface IProductRepository : IRepositoryBase<Product> 
    {
        Task<bool> UpsertAsync(Product entity, bool isUpdating);
        Task<bool> CreateAsync(Product entity);
        Task<bool> DeleteAsync(Product entity);
        Task<IEnumerable<Product>> ReadAsync();
        Task<Product> FindAsync(int id);
        Task<bool> UpdateAsync(Product entity);
        Task<bool> UpdateManyAsync(IEnumerable<Product> entities);
        Task<bool> ExistsAsync(Product entity);

    }

    public class ProductRepository(ProductDbContext context) : RepositoryBase<Product>(context), IProductRepository
    {
    }

