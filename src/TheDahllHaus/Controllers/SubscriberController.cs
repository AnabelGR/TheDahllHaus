﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheDahllHaus.Controllers
{
    public class SubscriberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
