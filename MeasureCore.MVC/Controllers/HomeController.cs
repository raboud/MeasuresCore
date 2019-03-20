using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeasureCore.MVC.Models;
using Microsoft.Extensions.Logging;

namespace MeasureCore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this._logger = logger;
        }

        public IActionResult Index()
        {
            this._logger.LogInformation("HomeController - Index");
            this._logger.LogWarning("HomeController - Index");
            this._logger.LogDebug("HomeController - Index");
            this._logger.LogCritical("HomeController - Index");
            this._logger.LogTrace("HomeController - Index");
            this._logger.LogError("HomeController - Index");
            try
            {
                throw (new Exception("YOU SUCK"));
            }
            catch (Exception ex)
            {
                this._logger.LogCritical(ex, "HomeController - Index");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
