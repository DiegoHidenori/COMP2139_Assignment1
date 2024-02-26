using COMP2139_Assignment1.Data;
using COMP2139_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139_Assignment1.Controllers
{
    public class AddFlightController : Controller
    {
        private readonly AppDbContext _context;

        public AddFlightController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Flight/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: /Flight/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Flight flight)
        {
            if (ModelState.IsValid)
            {
                // Add the hotel to the database
                _context.Flights.Add(flight);
                _context.SaveChanges();

                // Redirect to the same page
                return RedirectToAction(nameof(Add));
            }
            return View(flight);
        }
    }
}
