using System.IO.Pipelines;

namespace COMP2139_Assignment1.Models
{
    public interface IShoppingCart
    {
        void AddToCart(int id, int number, string type);

        //int RemoveFromCart(IShoppingCartItem item);

        List<ShoppingCartItem> GetShoppingCartItems();

        void ClearCart();

        //decimal GetShoppingCartTotal(); // changed from decimal to double because of errors in ShoppingCart.cs

        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
