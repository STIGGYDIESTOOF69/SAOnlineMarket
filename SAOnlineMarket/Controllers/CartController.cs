using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAOnlineMarket.Controllers;
using SAOnlineMarket.Data;
using SAOnlineMarket.Services;
using SAOnlineMarket.Models;


namespace SAOnlineMart.Controllers
{
    public class CartController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly SAOnlineMarketContext _context;
        public IActionResult Index()
        {
            var cartItems = CartService.GetCartItems();
            ViewBag.Total = CartService.GetCartTotal();
            return View(cartItems);
        }

        [HttpPost]
        public IActionResult AddToCart(int id)
        {
            var product = _context.Product.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                CartService.AddToCart(product);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int id)
        {
            CartService.RemoveFromCart(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int id, int quantity)
        {
            CartService.UpdateQuantity(id, quantity);
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            var cartItems = CartService.GetCartItems();
            if (!cartItems.Any())
            {
                return RedirectToAction("Index");
            }
            return View(cartItems);
        }

        [HttpPost]
        public IActionResult ProcessCheckout(Order order)
        {
            // Handle order processing and save the order details
            CartService.ClearCart(); // Clear the cart after successful order
            return RedirectToAction("OrderConfirmation");
        }

        public IActionResult OrderConfirmation()
        {
            return View();
        }
    }
}
