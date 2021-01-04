using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
    public interface IFrontendService
    {

        void Add(Frontend entity);
        void Update(Frontend entity);
        void Delete(Frontend entity);
        Frontend Get(int id);
        List<Frontend> GetList();
    }
}
