namespace RapidApiHotelProject.Models
{
    public class HotelSearchViewModel
    {
        public string ArrivalDate { get; set; }
        public string DestinationId { get; set; }
        public string SearchType { get; set; }
        public int Hotels { get; set; }
        public string DepartureDate { get; set; }
        public int Adults { get; set; }
        public string ChildrenAge { get; set; } // Örn: "1,17"
        public int RoomQty { get; set; }
    }

}
