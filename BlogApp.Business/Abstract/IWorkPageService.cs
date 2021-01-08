using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
    public interface IWorkPageService
    {

        List<WorkPage> GetList();

        WorkPage Get(int id);

        void Add(WorkPage entity);

        void Update(WorkPage entity);
        
        void Delete(WorkPage entity);

    }
}
