using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class HomePageManager : IHomeService
    {

        private readonly IHomeDal _homedal;

        public HomePageManager(IHomeDal homedal)
        {
            _homedal = homedal;
        }

        public void Add(HomePage entity)
        {
            _homedal.Add(entity);
        }

        public void Delete(HomePage entity)
        {
            _homedal.Delete(entity);
        }

        public HomePage Get(int id)
        {
            return  _homedal.Get(hp=>hp.Id==id);
        }

        public List<HomePage> GetList()
        {
           return _homedal.GetList();
        }

        public void Update(HomePage entity)
        {
            _homedal.Update(entity);
        }
    }
}
