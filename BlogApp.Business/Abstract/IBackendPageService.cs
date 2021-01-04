using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IBackendPageService
    {


        List<BackendPage> GetList();

        BackendPage Get(int id);

        void Add(BackendPage entity);

        void Update(BackendPage entity);

        void Delete(BackendPage entity);
    }
}
