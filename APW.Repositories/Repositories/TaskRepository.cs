using APW.Data;

namespace APW.Repositories;

public class TaskRepository : RepositoryBase<APW.Models.Task>, ITaskRepository
{
    public TaskRepository(ProductDbContext db) : base(db) { }
}