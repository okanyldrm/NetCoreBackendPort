using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Business.Abstract;
using Entities.ComplexType;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace BlogApp.API.Controllers
{
    //[Authorize(Roles = UserRoles.Admin)]
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : Controller
    {

        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }


        [HttpGet("getallevent")]
        public IActionResult GetAllEvent()
        {
            var model = _eventService.GetList();
            return Json(model);

        }

        [HttpPost("addevent")]
        public IActionResult AddEvent([FromBody] Event entity)
        { 
            
            _eventService.Add(entity);
            return Ok();

        }

        [HttpGet("getbyidevent/{id}")]
        public IActionResult GetByStringId(string id)
        {
            var model=_eventService.GetByStringId(id);
            return Json(model);
        }

        [HttpDelete("deleteevent/{id}")]
        public IActionResult DeleteEvent(string id)
        {
            var deleteModel = _eventService.GetByStringId(id);
            _eventService.Delete(deleteModel);
            return Ok();
        }

        [HttpGet("eventcount")]
        public IActionResult GetEventCount()
        {
            var model = _eventService.GetCountEvent();
            return Json(model);

        }

        [HttpGet("GetEventCategory")]
        public IActionResult GetEventCategory()
        {
            var model = _eventService.GetEventCategory();
            return Json(model);
        }



        [HttpGet("GetWeekEvent")]
        public IActionResult GetWeekEvent()
        {
            var model = _eventService.GetWeekEvent();
            return Json(model);
        }

    }
}
