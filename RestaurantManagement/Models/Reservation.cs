using System;

namespace RestaurantManagement.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime TimeOfReservation { get; set; }
        public int PeopleCount { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public DateTime CheckInTime { get; set; }
    }
}
