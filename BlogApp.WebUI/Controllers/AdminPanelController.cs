using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.WebUI.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Bloglarim()
        {
            return View();
        }


        public IActionResult BlogEkle()
        {
            return View();
        }

        public IActionResult HomeIndex()
        {
            return PartialView("FormElementDefault");
        }

        public IActionResult ContactIndex()
        {
            return View();
        }

        public IActionResult ServicesIndex()
        {
            return View();
        }

        public IActionResult WorkIndex()
        {
            return View();
        }

        public IActionResult AboutIndex()
        {
            return View();
        }


    }
}
