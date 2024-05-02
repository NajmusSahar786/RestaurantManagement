using System.Collections.Generic;

namespace RestaurantManagement.Models
{
    public interface IEmployee2Repository
    {
        Employee2 GetEmployee(int Id);
        IEnumerable<Employee2> GetAllEmployee();
        Employee2 Add(Employee2 employee);
   
        Employee2 Update(Employee2 employeeChanges);
        Employee2 Delete(int Id);
    }
}

