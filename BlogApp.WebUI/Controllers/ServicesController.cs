using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.WebUI.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Backend()
        {
            return View();
        }


        public IActionResult Frontend()
        {
            return View();
        }



        public IActionResult Devops()
        {
            return View();
        }


        public IActionResult Database()
        {
            return View();
        }

    }
}
