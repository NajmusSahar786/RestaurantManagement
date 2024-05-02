using Microsoft.EntityFrameworkCore;

namespace RestaurantManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee2>().HasData(
                     new Employee2
                     {
                         Id = 1,
                         Name = "Mary",
                         Department = Dept.IT,
                         Email = "mary@pragimtech.com"
                     },
            new Employee2
            {
                Id = 2,
                Name = "John",
                Department = Dept.HR,
                Email = "john@pragimtech.com"
            }
                );
        }
    }
}
