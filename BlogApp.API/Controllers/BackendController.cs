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
 
    public class BackendController : Controller
    {
        private readonly IBackendService _backendService;
       

        public BackendController(IBackendService backendService)
        {
            _backendService = backendService;
        }

        [HttpGet("getallbackend")]
        public IActionResult GetListBackend()
        {
            var model = _backendService.GetList();
            return Json(model);

        }



        [HttpGet("getbackend/{id}")]
        public IActionResult GetBackend(int id)
        {
            var model = _backendService.Get(id);
            return Json(model);
        }


        [HttpPost("updatebackend")]
        public IActionResult Updatebackend([FromBody] Backend entity )
        {
            _backendService.Update(entity);
            return Ok();
        }


    }
}
