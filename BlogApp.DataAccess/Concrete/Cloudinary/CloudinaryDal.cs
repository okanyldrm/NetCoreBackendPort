using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.DataAccess.Abstract;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace BlogApp.DataAccess.Concrete.Cloudinary
{
    public class CloudinaryDal : ICloudinaryDal
    {

        
        
        

        public CloudinaryDal()
        {
            Account account = new Account(CLOUD_NAME, API_KEY, API_SECRET);
            Cloudinary = new CloudinaryDotNet.Cloudinary(account);
        }


        public void UploadImage(string imagePath)
        {
            try
            {
                var uploadParam = new ImageUploadParams()
                {
                    File = new FileDescription(imagePath)
                };
                var uploadResult = Cloudinary.UploadAsync(uploadParam);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
