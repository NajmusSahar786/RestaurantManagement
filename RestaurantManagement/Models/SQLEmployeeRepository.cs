using System.Collections.Generic;

namespace RestaurantManagement.Models
{
    public class SQLEmployeeRepository : IEmployee2Repository
    {
        private AppDbContext _context;

        public SQLEmployeeRepository(AppDbContext context)
        {
            this._context = context;
        }
        public Employee2 Add(Employee2 employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

       

        public IEnumerable<Employee2> GetAllEmployee()
        {
            return _context.Employees;
        }

        public Employee2 GetEmployee(int Id)
        {
            return _context.Employees.Find(Id);
        }

       
        public Employee2 Delete(int Id)
        {
            Employee2 employee = _context.Employees.Find(Id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
        }
        public Employee2 Update(Employee2 employeeChanges)
        {
            var employee = _context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;
        }
    }
}
