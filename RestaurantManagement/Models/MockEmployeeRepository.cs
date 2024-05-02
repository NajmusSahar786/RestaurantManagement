using System.Collections.Generic;
using System.Linq;

namespace RestaurantManagement.Models
{
    public class MockEmployee2Repository : IEmployee2Repository
    {
        private readonly List<Employee2> _employeeList;
        public MockEmployee2Repository()
        {
            _employeeList = new List<Employee2>()
                {
                    new Employee2(){Id=1,Name="Mary",Department=Dept.HR,Email="mary@gmail.com"},
                    new Employee2(){Id=2,Name="John",Department=Dept.IT,Email="john@gmail.com"},
                    new Employee2(){Id=3,Name="Sam",Department=Dept.PayRoll,Email="sam@gmail.com"}
                };
        }

        public Employee2 Add(Employee2 employee)
        {
           employee.Id= _employeeList.Max(x => x.Id) + 1;
            _employeeList.Add(employee);
            return employee;    
        }

        

        public IEnumerable<Employee2> GetAllEmployee()
        {
            return _employeeList.ToList();
        }

        public Employee2 GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee2 Update(Employee2 employeeChanges)
        {
            Employee2 employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
        public Employee2 Delete(int Id)
        {
            Employee2 employee = _employeeList.FirstOrDefault(e => e.Id == Id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

    }
}
