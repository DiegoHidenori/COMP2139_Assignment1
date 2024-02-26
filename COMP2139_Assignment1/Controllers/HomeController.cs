using COMP2139_Assignment1.Models;
using COMP2139_Assignment1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP2139_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFlightRepository _flightRepository;
        private readonly ICarRepository _carRepository;
        private readonly IHotelRepository _hotelRepository;

        public HomeController(IFlightRepository flightRepository, ICarRepository carRepository, IHotelRepository hotelRepository)
        {
            _flightRepository = flightRepository;
            _carRepository = carRepository;
            _hotelRepository = hotelRepository;
        }

        public IActionResult Index()
        {
            var flightHotDeals = _flightRepository.FlightsHotDeals;
            var carHotDeals = _carRepository.CarsHotDeals;
            var hotelHotDeals = _hotelRepository.HotelsHotDeals;
            var homeViewModel = new HomeViewModel(flightHotDeals, hotelHotDeals, carHotDeals);

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
