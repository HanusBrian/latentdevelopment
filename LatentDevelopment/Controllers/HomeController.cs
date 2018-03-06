using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LatentDevelopment.Models;

namespace LatentDevelopment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Development()
        {
            ViewData["Message"] = "Development Journey";
            return View();
        }

        public IActionResult Lifestyle()
        {
            ViewData["Message"] = "Lifestyle";
            return View();
        }

        public IActionResult Resume()
        {
            ViewData["Message"] = "Resume";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About me";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
