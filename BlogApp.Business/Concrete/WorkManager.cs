using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class WorkManager : IWorkService
    {

        private readonly IWorkDal _workDal;

        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        public void Add(Work entity)
        {
           _workDal.Add(entity);
        }

        public void Update(Work entity)
        {
            _workDal.Update(entity);
        }

        public void Delete(Work entity)
        {
           _workDal.Delete(entity);
        }

        public Work Get(int id)
        {
            return _workDal.Get(w => w.Id == id);
        }

        public List<Work> GetList()
        {
            return _workDal.GetList();
        }
    }
}
