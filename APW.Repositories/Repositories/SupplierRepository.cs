using APW.Data;
using APW.Models;

namespace APW.Repositories;

public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
{
    public SupplierRepository(ProductDbContext db) : base(db) { }
}