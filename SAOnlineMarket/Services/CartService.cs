using SAOnlineMarket.Models;
using System.Collections.Generic;
using System.Linq;

namespace SAOnlineMarket.Services
{
    public static class CartService
    {
        private static List<CartItem> _cart = new List<CartItem>();

        public static void AddToCart(Product product, int quantity = 1)
        {
            var existingItem = _cart.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _cart.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public static void RemoveFromCart(int productId)
        {
            var itemToRemove = _cart.FirstOrDefault(i => i.Product.ProductId == productId);
            if (itemToRemove != null)
            {
                _cart.Remove(itemToRemove);
            }
        }

        public static void UpdateQuantity(int productId, int quantity)
        {
            var item = _cart.FirstOrDefault(i => i.Product.ProductId == productId);
            if (item != null && quantity > 0)
            {
                item.Quantity = quantity;
            }
            else if (quantity == 0)
            {
                RemoveFromCart(productId);
            }
        }

        public static IEnumerable<CartItem> GetCartItems()
        {
            return _cart;
        }

        public static decimal GetCartTotal()
        {
            return _cart.Sum(i => i.Product.ProductPrice * i.Quantity);
        }

        public static void ClearCart()
        {
            _cart.Clear();
        }
    }

    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
