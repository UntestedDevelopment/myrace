﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myrace.web.Models;

namespace myrace.web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            System.Diagnostics.Trace.TraceInformation("Index view requested");
            return View();
        }

        public IActionResult About()
        {
            System.Diagnostics.Trace.TraceInformation("About view requested");
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            System.Diagnostics.Trace.TraceInformation("Contact view requested");
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            System.Diagnostics.Trace.TraceError("Error action triggered");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
