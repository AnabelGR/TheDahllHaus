using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace TheDahllHaus.Controllers
{
    public class RepairController : Controller
    {
        public IActionResult Altercations()
        {
            return View();
        }
        public IActionResult Repairs()
        {
            return View();
        }
    }
}
