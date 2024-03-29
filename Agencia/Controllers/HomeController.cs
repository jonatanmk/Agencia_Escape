﻿using Agencia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Agencia.Controllers
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

        public IActionResult Destinos()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }

        public IActionResult Reserva()
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