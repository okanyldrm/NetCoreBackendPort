using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Abstract
{
    public interface ICloudinaryDal
    {

        void UploadImage(string imagePath);


    }
}
