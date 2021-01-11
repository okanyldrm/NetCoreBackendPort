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
    public class BlogPageController : Controller
    {

        private readonly IBlogPageService _blogPageService;

        public BlogPageController(IBlogPageService blogPageService)
        {
            _blogPageService = blogPageService;
        }


        [HttpGet("getblogpage")]
        public IActionResult GetBlogPage()
        {
           var model= _blogPageService.Get(1);
           return Json(model);
        }

        [HttpPost("updateblogpage")]
        public IActionResult UpdateBlogPage([FromBody] BlogPage entity)
        {
            _blogPageService.Update(entity);
            return Ok();
        }
    }
}
