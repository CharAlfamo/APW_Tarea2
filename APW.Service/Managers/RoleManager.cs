using APW.Data;
using APW.Models;

namespace APW.Repositories;

public class RoleRepository : RepositoryBase<Role>, IRoleRepository
{
    public RoleRepository(ProductDbContext db) : base(db) { }
}