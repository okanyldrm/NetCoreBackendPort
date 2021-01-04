using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IBackendService
    {

        void Add(Backend entity);
        void Update(Backend entity);
        void Delete(Backend entity);
        Backend Get(int id);
        List<Backend> GetList();



    }
}
