using ListingTodos.Entities;
using ListingTodos.Models;
using System.Collections.Generic;
using System.Linq;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        private TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public IList<Todo> ListAll()
        {
            return todoContext.Todos.ToList();
        }

        public IList<Todo> IsActive()
        {
            return todoContext.Todos.Where(x => x.IsDone == false).ToList();
        }
    }
}
