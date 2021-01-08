using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class DevopsManager : IDevopsService
    {

        private readonly IDevopsDal _devopsDal;

        public DevopsManager(IDevopsDal devopsDal)
        {
            _devopsDal = devopsDal;
        }

        public void Add(Devops entity)
        {
            _devopsDal.Add(entity);
        }

        public void Update(Devops entity)
        {
           _devopsDal.Update(entity);
        }

        public void Delete(Devops entity)
        {
            _devopsDal.Delete(entity);
        }

        public Devops Get(int id)
        {
            return _devopsDal.Get(d => d.Id == id);
        }

        public List<Devops> GetList()
        {
            return _devopsDal.GetList();
        }
    }
}
