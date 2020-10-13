using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SunsetHillsMVC.Models;

namespace SunsetHillsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Solution()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Solution(int b1, int b2, int b3, int b4, int b5)
        {
            var data = new StringBuilder();
            data.Append(b1.ToString());
            data.Append(b2.ToString());
            data.Append(b3.ToString());
            data.Append(b4.ToString());
            data.Append(b5.ToString());
            ViewData["Data"] = data;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
