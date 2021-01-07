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
    public class DevopsPageController : Controller
    {

        private readonly IDevopsPageService _devopsPageService;

        public DevopsPageController(IDevopsPageService devopsPageService)
        {
            _devopsPageService = devopsPageService;
        }

        [HttpGet("getdevopspage")]
        public IActionResult GetDevopsPage()
        {
            var model = _devopsPageService.Get(1);
            return Json(model);
        }

        [HttpPost("updatedevopspage")]
        public IActionResult UpdateDevopsPage([FromBody] DevopsPage entity)
        {
            _devopsPageService.Update(entity);
            return Ok();
        }
    }
}
