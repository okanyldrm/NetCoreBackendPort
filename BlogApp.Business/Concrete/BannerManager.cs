using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class BannerManager : IBannerService
    {


        private readonly IBannerDal _bannerDal;

        public BannerManager(IBannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

        public void Add(Banner entity)
        {
            _bannerDal.Add(entity);
        }

        public void Delete(Banner entity)
        {
            _bannerDal.Delete(entity);
        }

        public Banner Get(int id)
        {
           return _bannerDal.Get(b=>b.Id==id);
        }

        public List<Banner> GetList()
        {
           return _bannerDal.GetList();
        }

        public void Update(Banner entity)
        {
            _bannerDal.Update(entity);
        }
    }
}
