using BlogApp.Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Abstract
{
    public interface IBannerDal : IRepository<Banner>
    {
        //EfRepository dışı isteklerin abstracları

    }
}
