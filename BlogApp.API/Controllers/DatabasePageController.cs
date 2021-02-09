using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace BlogApp.API.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class DatabasePageController : Controller
    {

        private readonly IDatabasePageService _databasePageService;

        public DatabasePageController(IDatabasePageService databasePageService)
        {
            _databasePageService = databasePageService;
        }


        [HttpGet("getdatabasepage")]
        public IActionResult GetDatabasePage()
        {
            var model = _databasePageService.Get(1);
            return Json(model);
        }

        [HttpPost("updatedatabasepage")]
        public IActionResult UpdateDatabasePage([FromBody] DatabasePage entity)
        {
            _databasePageService.Update(entity);
            return Ok();
        }
    }
}
