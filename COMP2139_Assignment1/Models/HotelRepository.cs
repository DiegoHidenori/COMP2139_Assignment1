using COMP2139_Assignment1.Data;

namespace COMP2139_Assignment1.Models
{
    public class HotelRepository : IHotelRepository
    {
        public readonly AppDbContext _appDbContext;

        public HotelRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Hotel> AllHotels
        {
            get
            {

                return _appDbContext.Hotels;
            }
        }

        public IEnumerable<Hotel> HotelsHotDeals
        {
            get
            {
                return _appDbContext.Hotels.Where(p => p.isHotDeal);
            }
        }

        public Hotel? GetHotelById(int id)
        {
            return _appDbContext.Hotels.FirstOrDefault(p => p.id == id);
        }
    }
}
