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

        public void AddTodo(string title)
        {
            Todo newTodo = new Todo()
            {
                Title = title
            };
            todoContext.Todos.Add(newTodo);

            todoContext.SaveChanges();
        }

        public void Remove(long id)
        {
            Todo deleted = todoContext.Todos.FirstOrDefault(x => x.Id == id);
            todoContext.Todos.Remove(deleted);
            todoContext.SaveChanges();
        }

        public Todo TodoDetails(long id)
        {
            return todoContext.Todos.FirstOrDefault(x => x.Id == id);
        }

        public void Edit(long id, Todo edited)
        {
            todoContext.Todos.FirstOrDefault(x => x.Id == id).Title = edited.Title;
            todoContext.Todos.FirstOrDefault(x => x.Id == id).IsDone = edited.IsDone;
            todoContext.Todos.FirstOrDefault(x => x.Id == id).IsUrgent = edited.IsUrgent;
            //todoContext.Todos.Update(edited);
            todoContext.SaveChanges();
        }
    }
}
