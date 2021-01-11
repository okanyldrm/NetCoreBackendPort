using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
    public interface IBlogPageService
    {


        void Add(BlogPage entity);
        void Delete(BlogPage entity);
        void Update(BlogPage entity);
        BlogPage Get(int id);
        List<BlogPage> GetList();


    }
}
