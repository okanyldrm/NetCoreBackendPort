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
    public class ChartController : Controller
    {
        private readonly IChartService _chartService;

        public ChartController(IChartService chartService)
        {
            _chartService = chartService;
        }



        [HttpGet("getchartmodel")]
        public IActionResult GetChartSize()
        {
            var model = _chartService.getChartModel();

            return Json(model);


        }
    }
}
