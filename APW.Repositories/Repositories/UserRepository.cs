using APW.Data;
using APW.Models;

namespace APW.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(ProductDbContext db) : base(db) { }
}