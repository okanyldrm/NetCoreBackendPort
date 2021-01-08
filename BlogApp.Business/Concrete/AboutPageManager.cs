using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class AboutPageManager : IAboutPageService
    {

        private readonly IAboutPageDal _aboutPageDal;

        public AboutPageManager(IAboutPageDal aboutPageDal)
        {
            _aboutPageDal = aboutPageDal;
        }

        public List<AboutPage> GetList()
        {
            return _aboutPageDal.GetList();
        }

        public AboutPage Get(int id)
        {
            return _aboutPageDal.Get(ap => ap.Id == id);
        }

        public void Add(AboutPage entity)
        {
            _aboutPageDal.Add(entity);
        }

        public void Update(AboutPage entity)
        {
           _aboutPageDal.Update(entity);
        }

        public void Delete(AboutPage entity)
        {
            _aboutPageDal.Delete(entity);
        }
    }
}
