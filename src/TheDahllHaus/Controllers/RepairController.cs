using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheDahllHaus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace TheDahllHaus.Controllers
{
    public class RepairController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
