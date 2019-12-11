using MongoDB.Driver;
using ToDo.Entities.Entities;

namespace ToDo.Data.Abstract.DBContext
{
    public interface ITodoContext
    {
        IMongoCollection<Todo> Todos { get; }
    }
}
