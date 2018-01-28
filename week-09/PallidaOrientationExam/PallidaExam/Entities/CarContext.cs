using Microsoft.EntityFrameworkCore;
using PallidaExam.Models;

namespace PallidaExam.Entities
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
    }
}
