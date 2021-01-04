using BlogApp.Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FrontendPageController : Controller
    {

        private readonly IFrontendPageService _frontendPageService;

        public FrontendPageController(IFrontendPageService frontendPageService)
        {
            _frontendPageService = frontendPageService;
        }

      
        [HttpGet("getfrontendpage")]
        public IActionResult GetFrontendPage()
        {
            var model = _frontendPageService.Get(1);
            return Json(model);
        }


        [HttpPost("frontendpageupdate")]
        public IActionResult FrontendPageUpdate([FromBody]FrontendPage entity)
        {
            _frontendPageService.Update(entity);
            return Ok();
        }

    }
}
