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
                    new Employee2(){Id=1,Name="Mary",Department="HR",Email="mary@gmail.com"},
                    new Employee2(){Id=2,Name="John",Department="IT",Email="john@gmail.com"},
                    new Employee2(){Id=3,Name="Sam",Department="IT",Email="sam@gmail.com"}
                };
        }

      

        public IEnumerable<Employee2> GetAllEmployee()
        {
            return _employeeList.ToList();
        }

        public Employee2 GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
