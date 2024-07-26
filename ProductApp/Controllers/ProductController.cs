using Microsoft.AspNetCore.Mvc;
using System.Security;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult walk()
        {
            return View("w");
            
        }
    }
}
