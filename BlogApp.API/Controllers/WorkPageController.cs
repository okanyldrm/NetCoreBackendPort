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
    public class WorkPageController : Controller
    {

        private readonly IWorkPageService _workPageService;

        public WorkPageController(IWorkPageService workPageService)
        {
            _workPageService = workPageService;
        }


        [HttpGet("getworkpage")]
        public IActionResult GetWorkPage()
        {
            var model = _workPageService.Get(1);
            return Json(model);
        }


        [HttpPost("updateworkpage")]
        public IActionResult UpdateWorkPage([FromBody] WorkPage entity)
        {
            _workPageService.Update(entity);
            return Ok();
        }


    }
}
