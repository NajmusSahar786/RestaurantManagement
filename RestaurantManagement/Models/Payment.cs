using System;

namespace RestaurantManagement.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
