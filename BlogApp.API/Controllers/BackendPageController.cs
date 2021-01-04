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
    public class BackendPageController : Controller
    {


        private readonly IBackendPageService _backendPageService;

        public BackendPageController(IBackendPageService backendPageService)
        {
            _backendPageService = backendPageService;
        }

        //api/BackendPage/backendpage
        [HttpGet("backendpage")]
        public IActionResult GetBackendPage()
        {
            var model = _backendPageService.Get(1);
            return Json(model);
        }



        //api/BackendPage/backendpage
        [HttpPost("backendpageupdate")]
        public IActionResult BackendPageUpdate([FromBody] BackendPage entity)
        {
            _backendPageService.Update(entity);
            return Ok();
        }


    }
}
