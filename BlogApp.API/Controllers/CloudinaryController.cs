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
    public class CloudinaryController : Controller
    {

        private readonly ICloudinaryService _cloudinaryService;

        public CloudinaryController(ICloudinaryService cloudinaryService)
        {
            _cloudinaryService = cloudinaryService;
        }


        [HttpPost("loadimage")]
        public IActionResult LoadImage([FromBody]Cloudinary cloudinary)
        {
            var sizeImgUrl = cloudinary.ImageUrl.Length;
            var filepath = System.Text.Json.JsonSerializer.Serialize<Cloudinary>(cloudinary).Substring(13,sizeImgUrl);
            var newfilepath = filepath.Replace("/", "\\");
            _cloudinaryService.LoadImage(newfilepath);
            return Ok();
        }
    }
}
