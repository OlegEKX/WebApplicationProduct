using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondWebApp.Models;

namespace SecondWebApp.Controllers
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
            Product product = new Product("Коленвал", 15000, "смотри инструкцию", "/images/Мотор.jpg");
            ViewBag.Product = product;
            return View();
        }

        public IActionResult Product(string ProductName, decimal Cost, string Description, string pathImage)
        {
            //ViewBag.ProductName = ProductName;
            //ViewData["ProductName"] = ProductName;
            ViewBag.Cost = Cost;

            Product product = new Product(ProductName, Cost, Description, pathImage);
            ViewBag.Product = product;

            //TempData["ProductName"] = ProductName;
            //po

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
