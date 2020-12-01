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

   
    public class HomeController : Controller
    {


        private readonly IBannerService _bannerService;
        private readonly IProjectService _projectService;

        public HomeController(IBannerService bannerService, IProjectService projectService)
        {
            _bannerService = bannerService;
            _projectService = projectService;
        }



        public IActionResult Index()
        {
            var model = new HomeIndexViewModel()
            {
                BannerOdd = _bannerService.Get(1),
                Projects = _projectService.GetList()
            };
            return View(model);
        }


        //[HttpPost]
        //public IActionResult Add(Banner entity) 
        //{
        //    _bannerService.Add(entity);
        //    return RedirectToAction("Index");
        //}








    }

  
}
