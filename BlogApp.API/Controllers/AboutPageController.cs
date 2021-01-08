using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Business.Abstract;
using Entities.Concrete;

namespace BlogApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutPageController : Controller
    {

        private readonly IAboutPageService _aboutPageService;

        public AboutPageController(IAboutPageService aboutPageService)
        {
            _aboutPageService = aboutPageService;
        }

        [HttpGet("getaboutpage")]
        public IActionResult GetAboutPage()
        {
            var model = _aboutPageService.Get(1);
            return Json(model);
        }


        [HttpPost("updateaboutpage")]
        public IActionResult UpdateAboutPage([FromBody] AboutPage entity)
        {
            _aboutPageService.Update(entity);
            return Ok();
        }
    }
}
