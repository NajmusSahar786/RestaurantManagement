namespace RestaurantManagement.Models
{
    public class Employee2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept Department { get; set; }
    }

    public enum Dept
    {
        None,
        HR,
        IT,
        PayRoll
    }
}
