namespace RestaurantManagement.Models
{
    public class CheckTransaction:Payment
    {
      public string BankName { get; set; }
      public string CheckNumber { get; set; }
    }
}
