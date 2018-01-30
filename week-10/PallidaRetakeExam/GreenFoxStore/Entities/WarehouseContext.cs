using GreenFoxStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenFoxStore.Entities
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }

}
