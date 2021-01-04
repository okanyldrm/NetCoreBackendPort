using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class BackendPageManager : IBackendPageService
    {


        private readonly IBackendPageDal _backendPageDal;

        public BackendPageManager(IBackendPageDal backendPageDal)
        {
            _backendPageDal = backendPageDal;
        }


        public void Add(BackendPage entity)
        {
            _backendPageDal.Add(entity);
        }

        public void Delete(BackendPage entity)
        {
            _backendPageDal.Delete(entity);
        }

        public BackendPage Get(int id)
        {
            return _backendPageDal.Get(bp => bp.Id == id);
        }

        public List<BackendPage> GetList()
        {
            return _backendPageDal.GetList();
        }

        public void Update(BackendPage entity)
        {

            _backendPageDal.Update(entity);
        }
    }
}
