using System;
using COMP2139_Assignment1.Models;

namespace COMP2139_Assignment1.ViewModels
{
    public class FlightListViewModel
    {
        public IEnumerable<Flight> Flights { get; }
        public string? currentCategory { get; }

        public FlightListViewModel(IEnumerable<Flight> flights, string? category)
        {
            Flights = flights;
            currentCategory = category;
        }
    }
}
