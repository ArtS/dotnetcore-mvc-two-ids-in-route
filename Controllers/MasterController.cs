using Microsoft.AspNetCore.Mvc;
using RouteWithTwoIds.Models;

namespace RouteWithTwoIds.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(string name, string name2)
        {
            return View(new MasterDetailModel { Name = name, Name2 = name2 });
        }
    }
}