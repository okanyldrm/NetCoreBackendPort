using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class FrontendPageManager : IFrontendPageService
    {


        private readonly IFrontendPageDal _frontendPageDal;

        public FrontendPageManager(IFrontendPageDal frontendPageDal)
        {
            _frontendPageDal = frontendPageDal;
        }

        public void Add(FrontendPage entity)
        {
            _frontendPageDal.Add(entity);
        }

        public void Delete(FrontendPage entity)
        {
            _frontendPageDal.Delete(entity);
        }

        public FrontendPage Get(int id)
        {
            return _frontendPageDal.Get(fp => fp.Id == id);
        }

        public List<FrontendPage> GetList()
        {
            return _frontendPageDal.GetList();
        }

        public void Update(FrontendPage entity)
        {
            _frontendPageDal.Update(entity);
        }
    }
}
