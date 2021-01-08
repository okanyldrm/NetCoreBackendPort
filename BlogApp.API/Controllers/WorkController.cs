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
    public class WorkController : Controller
    {

        private readonly IWorkService _workService;

        public WorkController(IWorkService workService)
        {
            _workService = workService;
        }

        [HttpGet("getallwork")]
        public IActionResult GetAllWorkPAge()
        {
            var model = _workService.GetList();
            return Json(model);
        }

        [HttpPost("updatework")]
        public IActionResult UpdateWorkPage([FromBody] Work entity)
        {
            _workService.Update(entity);
            return Ok();
        }

        [HttpGet("getbyidwork/{id}")]
        public IActionResult GetByIdWork(int id)
        {
            var model = _workService.Get(id);
            return Json(model);
        }

    }
}
