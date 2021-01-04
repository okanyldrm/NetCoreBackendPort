using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class FrontendManager : IFrontendService
    {

        private readonly IFrontendDal _frontendDal;

        public FrontendManager(IFrontendDal frontendDal)
        {
            _frontendDal = frontendDal;
        }



        public void Add(Frontend entity)
        {
            _frontendDal.Add(entity);
        }

        public void Update(Frontend entity)
        {
            _frontendDal.Update(entity);
        }

        public void Delete(Frontend entity)
        {
            _frontendDal.Delete(entity);
        }

        public Frontend Get(int id)
        {
            return _frontendDal.Get(f => f.Id == id);
        }

        public List<Frontend> GetList()
        {
            return _frontendDal.GetList();
        }
    }
}
