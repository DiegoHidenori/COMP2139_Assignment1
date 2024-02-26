using COMP2139_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COMP2139_Assignment1.Pages
{
    public class CheckoutPageModel : PageModel
    {
        private readonly IShoppingCart _shoppingCart;

        public CheckoutPageModel(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        //public IActionResult OnPost()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    var items = _shoppingCart.GetShoppingCartItems();
        //    _shoppingCart.ShoppingCartItems = items;

        //    if (_shoppingCart.ShoppingCartItems.Count == 0)
        //    {
        //        ModelState.AddModelError("", "Your cart is empty, add some flights first");
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _shoppingCart.ClearCart();
        //        return RedirectToPage("CheckoutCompletePage");
        //    }

        //    return Page();
        //}

        public void OnGet()
        {
        }
    }
}
