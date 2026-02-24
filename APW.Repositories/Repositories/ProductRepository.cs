using APW.Data;
using APW.Models;

namespace APW.Repositories;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(ProductDbContext db) : base(db) { }
}