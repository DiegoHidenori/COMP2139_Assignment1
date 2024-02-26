using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COMP2139_Assignment1.Pages
{
    public class CheckoutCompletePageModel : PageModel
    {
        public void OnGet()
        {
            ViewData["CheckoutCompleteMessage"] = "Thanks for your order! Enjoy!!";
        }
    }
}
