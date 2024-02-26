namespace COMP2139_Assignment1.Models
{
    public interface IHotelRepository
    {
        IEnumerable<Hotel> AllHotels { get; }
        IEnumerable<Hotel> HotelsHotDeals { get; }
        Hotel? GetHotelById(int hotelId);
    }
}
