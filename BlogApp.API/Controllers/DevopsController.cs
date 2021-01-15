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
    public class DevopsController : Controller
    {

        private readonly IDevopsService _devopsService;

        public DevopsController(IDevopsService devopsService)
        {
            _devopsService = devopsService;
        }

        [HttpGet("getalldevops")]
        public IActionResult GetAllDevops()
        {
            var model = _devopsService.GetList();
            return Json(model);
        }

        [HttpGet("getbyiddevops/{id}")]
        public IActionResult GetByIdDevops(int id)
        {
            var model = _devopsService.Get(id);
            return Json(model);
        }


        [HttpPost("updatedevops")]
        public IActionResult UpdateDevops([FromBody] Devops entity)
        {
            _devopsService.Update(entity);
            return Ok();
        }


        [HttpPost("adddevops")]
        public IActionResult AddDevops([FromBody] Devops entity)
        {
            _devopsService.Add(entity);
            return Ok();
        }

        [HttpDelete("deletedevops/{id}")]
        public IActionResult DeleteDevops(int id)
        {
            var deletedModel = _devopsService.Get(id);
            _devopsService.Delete(deletedModel);
            return Ok();
        }

    }
}
