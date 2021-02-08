using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Business.Abstract;
using Entities.Concrete;
using Microsoft.Extensions.Logging;

namespace BlogApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutPageController : Controller
    {

        private readonly ILogger<AboutPageController> _logger;
        private readonly IAboutPageService _aboutPageService;

        public AboutPageController(IAboutPageService aboutPageService, ILogger<AboutPageController> logger)
        {
            _aboutPageService = aboutPageService;
            _logger = logger;
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
            _logger.LogInformation(" Update : Aboutpage ");
            return Ok();
        }
    }
}
