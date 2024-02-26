using COMP2139_Assignment1.Models;
using System.Collections.Generic;

namespace COMP2139_Assignment1.ViewModels
{
    public class ShoppingCartViewModel
    {
        // Properties to store data
        public IShoppingCart shoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
        public List<Car> Cars { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<Flight> Flights { get; set; }
    }
}
