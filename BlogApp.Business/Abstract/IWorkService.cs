using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
   public interface IWorkService
    {
        void Add(Work entity);
        void Update(Work entity);
        void Delete(Work entity);
        Work Get(int id);
        List<Work> GetList();
    }
}
