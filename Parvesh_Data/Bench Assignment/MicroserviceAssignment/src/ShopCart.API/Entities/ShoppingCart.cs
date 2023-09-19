﻿using System.Collections.Generic;

namespace ShopCart.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShopCartItem> Items { get; set; } = new List<ShopCartItem>();

        public ShoppingCart() { }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        // Calculate total price shop cart
        public decimal TotalPrice { 
            get {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Price * item.Quantity;
                }
                return totalPrice; 
            } 
        }
    }
}