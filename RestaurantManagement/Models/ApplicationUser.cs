using Microsoft.AspNetCore.Identity;

namespace RestaurantManagement.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string City { get; set; }
    }
}
