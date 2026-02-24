using APW.Data;
using APW.Models;

namespace APW.Repositories;

public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(ProductDbContext db) : base(db) { }
}