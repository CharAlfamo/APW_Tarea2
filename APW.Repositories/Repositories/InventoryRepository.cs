using APW.Data;
using APW.Models;

namespace APW.Repositories;

public class InventoryRepository : RepositoryBase<Inventory>, IInventoryRepository
{
    public InventoryRepository(ProductDbContext db) : base(db) { }
}