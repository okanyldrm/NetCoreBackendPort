using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IFrontendPageService
    {

        void Add(FrontendPage entity);
        void Delete(FrontendPage entity);
        void Update(FrontendPage entity);
        FrontendPage Get(int id);
        List<FrontendPage> GetList();

    }
}
