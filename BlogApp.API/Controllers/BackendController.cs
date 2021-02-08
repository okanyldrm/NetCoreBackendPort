using BlogApp.Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace BlogApp.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
 
    public class BackendController : Controller
    {
        private readonly IBackendService _backendService;
        private readonly ILogger<BackendController> _logger;

        public BackendController(IBackendService backendService, ILogger<BackendController> logger)
        {
            _backendService = backendService;
            _logger = logger;
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
            _logger.LogInformation(" Update Backend : "+entity.Title );
            return Ok();
        }

        [HttpPost("addbackend")]
        public IActionResult AddBackend([FromBody] Backend entity)
        {
            _logger.LogInformation(" Added Backend : " + entity.Title);
            _backendService.Add(entity);
            return Ok();

        }

        [HttpDelete("deletebackend/{id}")]
        public IActionResult DeleteBackend(int id)
        {
            
            var deletedEntity = _backendService.Get(id);
            _logger.LogWarning(" Delete Backend : " + deletedEntity.Title);
            _backendService.Delete(deletedEntity);
            return Ok();
        }


    }
}
