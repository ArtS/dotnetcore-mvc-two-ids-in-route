using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IActionResult Detail(int id, int id2)
        {
            return View(new MasterDetailModel { Id = id, Id2 = id2 });
        }
    }
}