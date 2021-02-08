using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BlogApp.Business.Abstract;
using Entities.Concrete;
using Microsoft.Extensions.Logging;

namespace BlogApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : Controller
    {

        private readonly IBlogService _blogService;
        private readonly ILogger<BlogController> _logger;

        public BlogController(IBlogService blogService, ILogger<BlogController> logger)
        {
            _blogService = blogService;
            _logger = logger;
        }

        [HttpGet("getallblog")]
        public IActionResult GetAllBlog()
        {
            var model = _blogService.GetList();
            return Json(model);
        }

        [HttpGet("getbyblog/{id}")]
        public IActionResult GetById(int id)
        {
            var model = _blogService.Get(id);
            return Json(model);
        }

        [HttpPost("updateblog")]
        public IActionResult UpdateBlog([FromBody] Blog entity)
        {
            _blogService.Update(entity);
            return Ok();
        }

        [HttpPost("blogadd")]
        public IActionResult AddBlog([FromBody] Blog entity)
        {
            _blogService.Add(entity);
            _logger.LogInformation("Added | "+entity.Title);
            return Ok();
        }

        [HttpDelete("blogdelete/{id}")]
        public IActionResult DeleteBlog(int id)
        {
            var deleteModel = _blogService.Get(id);
            _blogService.Delete(deleteModel);
            _logger.LogWarning("Deleted |"+deleteModel.Title);
            return Ok();
        }

    }
}
