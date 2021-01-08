using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Business.Abstract;

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

        [HttpGet("getlalldevops")]
        public IActionResult GetAllDevops()
        {
            var model = _devopsService.GetList();
            return Json(model);
        }


    }
}
