using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class WorkPageManager : IWorkPageService
    {

        private readonly IWorkPageDal _workPageDal;

        public WorkPageManager(IWorkPageDal workPageDal)
        {
            _workPageDal = workPageDal;
        }


        public List<WorkPage> GetList()
        {
            return _workPageDal.GetList();
            
        }

        public WorkPage Get(int id)
        {
            return _workPageDal.Get(wp => wp.Id == id);
        }

        public void Add(WorkPage entity)
        {
          _workPageDal.Add(entity);
        }

        public void Update(WorkPage entity)
        {
           _workPageDal.Update(entity);
        }

        public void Delete(WorkPage entity)
        {
           _workPageDal.Delete(entity);
        }
    }
}
