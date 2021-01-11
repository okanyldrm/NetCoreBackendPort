using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class BlogPageManager : IBlogPageService
    {

        private readonly IBlogPageDal _blogPageDal;

        public BlogPageManager(IBlogPageDal blogPageDal)
        {
            _blogPageDal = blogPageDal;
        }

        public void Add(BlogPage entity)
        {
           _blogPageDal.Add(entity);
        }

        public void Delete(BlogPage entity)
        {
            _blogPageDal.Delete(entity);
        }

        public void Update(BlogPage entity)
        {
           _blogPageDal.Update(entity);
        }

        public BlogPage Get(int id)
        {
            return _blogPageDal.Get(bp => bp.Id == id);
        }

        public List<BlogPage> GetList()
        {
            return _blogPageDal.GetList();
        }
    }
}
