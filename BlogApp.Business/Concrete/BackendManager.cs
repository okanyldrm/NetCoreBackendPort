using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class BackendManager : IBackendService

    {

        private readonly IBackendDal _backendDal;

        public BackendManager(IBackendDal backendDal)
        {
            _backendDal = backendDal;
        }



        public void Add(Backend entity)
        {
            _backendDal.Add(entity);
        }

        public void Delete(Backend entity)
        {
            _backendDal.Delete(entity);
        }

        public Backend Get(int id)
        {
            return _backendDal.Get(b => b.Id == id);
        }

        public List<Backend> GetList()
        {
            return _backendDal.GetList();
        }

        public void Update(Backend entity)
        {
            _backendDal.Update(entity);
        }
    }
}
