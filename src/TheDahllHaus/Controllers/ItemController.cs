using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheDahllHaus.Models;
using Microsoft.AspNetCore.Identity;

namespace TheDahllHaus.Controllers
{
    public class ItemController : Controller
    {
        private TheDahllHausDbContext db = new TheDahllHausDbContext();

        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }
        public IActionResult Costumes()
        {
            return View();
        }
        public IActionResult HatsAndFascinators()
        {
            return View();
        }
        public IActionResult Headdresses()
        {
            return View();
        }
        public IActionResult Masks()
        {
            return View();
        }
        public IActionResult Wigs()
        {
            return View();
        }
        public IActionResult Zines()
        {
            return View();
        }
    }
}
