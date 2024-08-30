using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAOnlineMarket.Data;
using SAOnlineMarket.Models;
using System.Diagnostics;

namespace SAOnlineMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SAOnlineMarketContext _context;
        

        public HomeController(ILogger<HomeController> logger, SAOnlineMarketContext context)
        
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Product.ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Details(int id)
        {
            var product = _context.Product.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
