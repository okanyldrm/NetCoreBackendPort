using BlogApp.Business.Abstract;
using BlogApp.WebUI.Models;
using Entities.Concrete;
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
        private readonly IProjectService _projectService;

        public AdminPanelController(IBannerService bannerService, ICategoryService categoryService, IProjectService projectService)
        {
            _bannerService = bannerService;
            _categoryService = categoryService;
            _projectService = projectService;
        }

        public IActionResult GeneralSetting()
        {
            var model = _bannerService.Get(1);


            return View("~/Views/AdminPanel/HomePageSetting/GeneralSetting.cshtml",model);
        }

        public IActionResult Update(Banner entity)
        {
           
            _bannerService.Update(entity);


            return RedirectToAction("GeneralSetting");
        }



        public IActionResult ProjectSetting()
        {

            var model = new ProjectViewModel()
            {
                Projects = _projectService.GetList()
            };

            return View("~/Views/AdminPanel/HomePageSetting/ProjectSetting.cshtml",model);
        }


        [HttpGet("AdminPanel/ProjectSetting/{id}")]
        public IActionResult ProjectSettingId(int id)
        {
            var model = _projectService.Get(id);

            return View("~/Views/Shared/ProjectSetting.cshtml",model);
        }


        [HttpPost]
        public IActionResult UpdateProject(Project entity)
        {
            _projectService.Update(entity);
            return RedirectToAction("ProjectSetting");
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

            var model = new BannerFormViewModel()
            {
                banner = _bannerService.Get(1),
                categories = _categoryService.GetList()
            };

            return PartialView("HomeForm" , model );
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
