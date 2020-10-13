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
            int[] arr = { b1, b2, b3, b4, b5 };
            var results = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    results.Add("Sun");
                    continue;
                }
                bool bigger = false;
                for (int j = 0; j < i; j++)
                {
                    if(arr[j] >= arr[i])
                    {
                        bigger = true;
                        break;
                    } 
                    else
                    {
                        continue;
                    }
                }
                if (bigger)
                {
                    results.Add("Shade");
                }
                else
                {
                    results.Add("Sun");
                }
            }
            ViewData["Input"] = string.Join(", ", arr);
            ViewData["Data"] = string.Join(", ", results);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
