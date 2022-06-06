﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.DAL.Concreate;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            var model = new EfWordDal().GetAll();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Hakkında()
        {
            return View();
        }

        public IActionResult Iletisim()
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