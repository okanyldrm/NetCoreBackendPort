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
    public class FrontendController : Controller
    {


        private readonly IFrontendService _frontendService;

        public FrontendController(IFrontendService frontendService)
        {
            _frontendService = frontendService;
        }

        [HttpGet("getallfrontend")]
        public IActionResult GetFrontendAll()
        {
            var model = _frontendService.GetList();
            return Json(model);
        }

        [HttpGet("getbyidfrontend")]
        public IActionResult GetByIdFrontend(int id)
        {
            var model = _frontendService.Get(id);
            return Json(model);
        }

        [HttpPost("updatefrontend")]
        public IActionResult UpdateFrontend([FromBody] Frontend entity)
        {
            _frontendService.Update(entity);
            return Ok();
        }




    }
}
