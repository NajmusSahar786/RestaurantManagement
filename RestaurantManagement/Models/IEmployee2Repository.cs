using System.Collections.Generic;

namespace RestaurantManagement.Models
{
    public interface IEmployee2Repository
    {
        Employee2 GetEmployee(int Id);
        IEnumerable<Employee2> GetAllEmployee();
        Employee2 Add(Employee2 employee);
    }
}
