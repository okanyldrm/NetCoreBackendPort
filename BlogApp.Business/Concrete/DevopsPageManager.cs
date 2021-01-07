using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class DevopsPageManager : IDevopsPageService
    {


        private readonly IDevopsPageDal _devopsPageDal;

        public DevopsPageManager(IDevopsPageDal devopsPageDal)
        {
            _devopsPageDal = devopsPageDal;
        }

        public List<DevopsPage> GetList()
        {
           return _devopsPageDal.GetList();
        }

        public DevopsPage Get(int id)
        {
            return _devopsPageDal.Get(dp => dp.Id == id);
        }

        public void Add(DevopsPage entity)
        {
            _devopsPageDal.Add(entity);
        }

        public void Update(DevopsPage entity)
        {
            _devopsPageDal.Update(entity);
        }

        public void Delete(DevopsPage entity)
        {
            _devopsPageDal.Delete(entity);
        }
    }
}
