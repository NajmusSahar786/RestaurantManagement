using System;

namespace RestaurantManagement.Models
{
    public class Employee:Person
    {
        public int EmployeeId { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
