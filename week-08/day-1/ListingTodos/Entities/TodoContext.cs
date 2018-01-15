using ListingTodos.Models;
using Microsoft.EntityFrameworkCore;

namespace ListingTodos.Entities
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
    }
}
