using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CentralizedApplicationLogging.Service2.Models;
using Microsoft.Extensions.Logging;

namespace CentralizedApplicationLogging.Service2.Controllers
{
    public class HomeController : Controller
    {
        ILogger _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("{Service}: Rendering the home page", nameof(Service2));
            _logger.LogWarning("{Service}: This is a warning", nameof(Service2));
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("{Service}: Rendering the privacy page", nameof(Service2));
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
