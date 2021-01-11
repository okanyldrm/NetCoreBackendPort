using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BlogApp.Business.Abstract;
using Entities.Concrete;

namespace BlogApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : Controller
    {

        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
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
    }
}
