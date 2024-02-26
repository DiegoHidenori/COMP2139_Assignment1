using Microsoft.AspNetCore.Mvc;

namespace COMP2139_Assignment1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
