using Microsoft.EntityFrameworkCore;

namespace RestaurantManagement.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
        }
        public DbSet<Employee2> Employees { get; set; }
    }
}
