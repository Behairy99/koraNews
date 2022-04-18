using FirstCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Controllers
{
    public class HomeController : Controller
    {
        NewsContext db;



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var result = db.Categories.ToList();

            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Players()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }




        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult seeMatch()
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
