using BlogApp.Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomePageController : Controller
    {

        private readonly IHomeService _homeService;

        public HomePageController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        //api/homepage/getbyhomepage
        [HttpGet("getbyhomepage")]
        public IActionResult GetById()
        {
            var model = _homeService.Get(1);
            return Json(model);
        }


        //api/homepage/updatehomepage
        [HttpPost("updatehomepage")]
        public IActionResult UpdateHomePage([FromBody]HomePage entity)
        {
            var tip=entity.Downloads.GetType();
  
            _homeService.Update(entity);
            return Ok();
        }
    }
}
