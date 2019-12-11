using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using ToDo.Entities.Entities;

namespace ToDo.Data.Abstract.Repositories
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> GetAllTodos();

        // api/1/[GET]
        Task<Todo> GetTodo(long id);

        // api/[POST]
        Task Create(Todo todo);

        // api/[PUT]
        Task<bool> Update(Todo todo);

        // api/1/[DELETE]
        Task<bool> Delete(long id);

        Task<long> GetNextId();
    }
}
