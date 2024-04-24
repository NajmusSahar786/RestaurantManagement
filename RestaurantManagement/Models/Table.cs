namespace RestaurantManagement.Models
{
    public class Table
    {
        public int TableId { get; set; }
        public string Status { get; set; }//type of tablestatus
        public int MaxCapacity { get; set; }
        public int LocationIdentifier { get; set; }
    }
}
