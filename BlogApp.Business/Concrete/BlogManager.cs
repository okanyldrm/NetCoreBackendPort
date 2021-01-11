using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class BlogManager : IBlogService
    {

        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog entity)
        {
         _blogDal.Add(entity);
        }

        public void Delete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public void Update(Blog entity)
        {
           _blogDal.Update(entity);
        }

        public Blog Get(int id)
        {
          return  _blogDal.Get(b => b.Id == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetList();
        }
    }
}
