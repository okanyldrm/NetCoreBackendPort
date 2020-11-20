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
            return PartialView("HomeForm");
        }

        public IActionResult ContactIndex()
        {
            return PartialView("ContactForm");
        }

        public IActionResult ServicesIndex()
        {
            return PartialView("ServicesForm");
        }

        public IActionResult WorkIndex()
        {
            return PartialView("WorkForm");
        }

        public IActionResult AboutIndex()
        {
            return PartialView("AboutForm");
        }

        public IActionResult EditBlog()
        {
            return PartialView("EditBlogForm");
        }


    }
}
