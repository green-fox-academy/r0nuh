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

        public List<Todo> ListAll()
        {
            return todoContext.Todos.ToList();
        }
    }
}
