using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
    public interface IDevopsService
    {
        void Add(Devops entity);
        void Update(Devops entity);
        void Delete(Devops entity);
        Devops Get(int id);
        List<Devops> GetList();


    }
}
