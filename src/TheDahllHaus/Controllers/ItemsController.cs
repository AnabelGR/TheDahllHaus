using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheDahllHaus.Models;
using Microsoft.AspNetCore.Identity;

namespace TheDahllHaus.Controllers
{
    public class ItemsController : Controller
    {
        private TheDahllHausDbContext db = new TheDahllHausDbContext();

        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }
        public IActionResult Categories()
        {
            return View(db.Categories.ToList());
        }
        
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
