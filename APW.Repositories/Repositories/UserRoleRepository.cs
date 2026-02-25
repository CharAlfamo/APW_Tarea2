using APW.Data;
using APW.Models;

namespace APW.Repositories;

public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
{
    public UserRoleRepository(ProductDbContext db) : base(db)
    {
    }
}