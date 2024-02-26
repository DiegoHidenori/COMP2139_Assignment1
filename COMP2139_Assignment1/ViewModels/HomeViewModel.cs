using System;
using COMP2139_Assignment1.Models;
using Microsoft.Identity.Client;

namespace COMP2139_Assignment1.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Flight> flightsHotDeals { get; }
        public IEnumerable<Hotel> hotelsHotDeals { get; }
        public IEnumerable<Car> carsHotDeals { get; }

        public HomeViewModel(IEnumerable<Flight> flightsHotDeals, IEnumerable<Hotel> hotelsHotDeals, IEnumerable<Car> carsHotDeals)
        {
            this.flightsHotDeals = flightsHotDeals;
            this.hotelsHotDeals = hotelsHotDeals;
            this.carsHotDeals = carsHotDeals;
        }
    }
}
