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
    public class DatabaseController : Controller
    {


        private readonly IDatabaseService _databaseService;

        public DatabaseController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }


        [HttpGet("getalldatabase")]
        public IActionResult GetAllDatabase()
        {
            var model = _databaseService.GetList();
            return Json(model);
        }

        [HttpGet("getbyiddatabase/{id}")]
        public IActionResult GetByIdDatabase(int id)
        {
            var model = _databaseService.Get(id);
            return Json(model);
        }



        [HttpPost("updatedatabase")]
        public IActionResult UpdataDatabase([FromBody] Database entity)
        {
            _databaseService.Update(entity);
            return Ok();
        }

    }
}
