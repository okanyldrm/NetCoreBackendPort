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
    public class FeatureController : Controller
    {


        private readonly IFeatureService _featureService;
        private readonly ILogger<FeatureController> _looger;

        public FeatureController(IFeatureService featureService, ILogger<FeatureController> looger)
        {
            _featureService = featureService;
            _looger = looger;
        }

        //api/Feature/Features
        [HttpGet("Features")]
        public IActionResult GetFeature()
        {
            var model = _featureService.GetList();
            return Json(model);
        }


        //api/Feature/getbyfeature/id
        [HttpGet("getbyfeature/{featureid}")]
        public IActionResult GetByFeature(int featureid)
        {
            var model = _featureService.Get(featureid);
            return Json(model);
        }

        //api/homepage/updatefeature
        [HttpPost("updatefeature")]
        public IActionResult UpdateHomePage([FromBody] Feature entity)
        {
    
            _featureService.Update(entity);
            return Ok();
        }

        [HttpPost("addfeature")]
        public IActionResult AddFeature([FromBody] Feature entity)
        {
            _featureService.Add(entity);
            _looger.LogInformation("Add Feature Title : "+entity.Title);
            return Ok();
        }

        [HttpDelete("deletefeature/{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var deletemodel = _featureService.Get(id);
            _featureService.Delete(deletemodel);
            return Ok();
        }

    }
}
