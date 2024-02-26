using COMP2139_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139_Assignment1.ViewModels
{
    public class HotelListViewModel
    {
        public IEnumerable<Hotel> Hotels { get; }
        public string? currentCategory { get; }

        public HotelListViewModel(IEnumerable<Hotel> hotels, string? category)
        {
            Hotels = hotels;
            currentCategory = category;
        }
    }
}
