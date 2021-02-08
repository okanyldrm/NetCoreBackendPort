using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;

namespace BlogApp.Business.Concrete
{

   public class CloudinaryManager :ICloudinaryService
   {


       private readonly ICloudinaryDal _cloudinaryDal;

       public CloudinaryManager(ICloudinaryDal cloudinaryDal)
       {
           _cloudinaryDal = cloudinaryDal;
       }


       public void LoadImage(string imagePath)
        {
           _cloudinaryDal.UploadImage(imagePath);
        }
    }
}
