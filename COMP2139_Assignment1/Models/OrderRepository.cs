﻿using COMP2139_Assignment1.Data;

namespace COMP2139_Assignment1.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, IShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;


            //adding the order with its details

            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();
        }
    }
}
