using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IHomeService
    {


        List<HomePage> GetList();

        HomePage Get(int id);

        void Add(HomePage entity);

        void Update(HomePage entity);

        void Delete(HomePage entity);
    }
}
