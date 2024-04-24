using System;

namespace RestaurantManagement.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Content { get; set; }
    }
}
