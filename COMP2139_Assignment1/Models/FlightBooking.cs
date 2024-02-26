namespace COMP2139_Assignment1.Models
{
    public class FlightBooking
    {
        public int id { get; set; }
        public int flightId { get; }
        public DateTime bookingDate { get; set; }
    }
}
