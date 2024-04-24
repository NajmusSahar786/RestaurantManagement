namespace RestaurantManagement.Models
{
    public class Bill
    {
        public int CheckId { get; set; }
        public double Amount { get; set; }
        public double Tip { get; set; }
        public double Tax { get; set; }
        public bool IsPaid { get; set; }
    }
}
