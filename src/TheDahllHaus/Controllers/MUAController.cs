using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheDahllHaus.Controllers
{
    public class MUAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Assistant()
        {
            return View();
        }
        public IActionResult Hairstylist()
        {
            return View();
        }
        public IActionResult Makeup()
        {
            return View();
        }
    }
}