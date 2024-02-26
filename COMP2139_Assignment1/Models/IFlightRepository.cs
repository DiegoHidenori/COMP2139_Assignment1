namespace COMP2139_Assignment1.Models
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> AllFlights { get; }
        IEnumerable<Flight> FlightsHotDeals { get; }
        Flight? GetFlightById(int flightId);
    }
}
