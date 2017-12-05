using Microsoft.AspNetCore.Mvc;

namespace route_with_two_ids.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }    
    }
}