using Microsoft.AspNetCore.Mvc;
using TechStore.Models;
namespace TechStore.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
             public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Precio,Descripcion,Igv")] Producto producto)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

    
    }
}