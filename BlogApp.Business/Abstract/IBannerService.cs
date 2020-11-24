using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IBannerService
    {


        List<Banner> GetList();

        Banner Get(int id);

        void Add(Banner entity);

        void Update(Banner entity);

        void Delete(Banner entity);











    }
}
