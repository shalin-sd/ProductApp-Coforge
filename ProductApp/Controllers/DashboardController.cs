using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var usr=HttpContext.Session.GetString("user");
            ViewBag.user = usr;
            return View();
        }
    }
}
