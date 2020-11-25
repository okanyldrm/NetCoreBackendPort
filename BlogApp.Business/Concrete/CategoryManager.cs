using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {


        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(c=>c.Id==id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetList();
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
