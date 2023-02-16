using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBalloon.Controllers
{
    public class BalloonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
