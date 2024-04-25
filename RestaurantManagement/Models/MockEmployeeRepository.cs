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
