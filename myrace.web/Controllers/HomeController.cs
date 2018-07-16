using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myrace.web.Models;

namespace myrace.web.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> _logger;
        private TelemetryClient telemetry = new TelemetryClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogDebug("Index view requested");
            telemetry.TrackTrace("Index view requested", SeverityLevel.Information);
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
