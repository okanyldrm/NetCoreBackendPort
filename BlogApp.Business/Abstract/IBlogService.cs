using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
    public interface IBlogService
    {

        void Add(Blog entity);
        void Delete(Blog entity);
        void Update(Blog entity);
        Blog Get(int id);
        List<Blog> GetList();


    }
}
