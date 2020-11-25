using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface ICategoryService
    {

        List<Category> GetList();

        Category Get(int id);

        void Add(Category entity);

        void Update(Category entity);

        void Delete(Category entity);








    }
}
