using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechStore.Models;

namespace TechStore.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;
         public ProductoController(ILogger<ProductoController> logger)
    {
        _logger = logger;
    }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            if (ModelState.IsValid)
            {
               
                return View("index");
            }

            return View(producto);
        }
         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
