using MongoDB.Driver;
using ToDo.Data.Abstract.DBContext;
using ToDo.Data.Concrete.Config;
using ToDo.Entities.Entities;

namespace ToDo.Data.Concrete.DBContext
{
    public class TodoContext:ITodoContext
    {
        private readonly IMongoDatabase _db;

        public TodoContext(MongoDbConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);
        }

        public IMongoCollection<Todo> Todos => _db.GetCollection<Todo>("Todos");
    }
}
