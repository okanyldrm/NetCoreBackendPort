using BlogApp.Business.Abstract;
using BlogApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.WebUI.Controllers
{
    public class AdminPanelController : Controller
    {


        private readonly IBannerService _bannerService;
        private readonly ICategoryService _categoryService;

        public AdminPanelController(IBannerService bannerService, ICategoryService categoryService)
        {
            _bannerService = bannerService;
            _categoryService = categoryService;
        }

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

            var model = new BannerFormViewModel() {
                banner = _bannerService.Get(1),
                categories = _categoryService.GetList()
            };

            return PartialView("HomeForm",model);
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
