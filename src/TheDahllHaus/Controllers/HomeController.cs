using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheDahllHaus.Models;

namespace TheDahllHaus.Controllers
{
    public class HomeController : Controller
    {
        private TheDahllHausDbContext db = new TheDahllHausDbContext();

        public IActionResult Splash()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Reviews()
        {
            return View();
        }
    }
}
