using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class DatabasePageManager : IDatabasePageService
    {

        private readonly IDatabasePageDal _databaseDal;

        public DatabasePageManager(IDatabasePageDal databaseDal)
        {
            _databaseDal = databaseDal;
        }


        public void Add(DatabasePage entity)
        {
           _databaseDal.Add(entity);
        }

        public void Delete(DatabasePage entity)
        {
            _databaseDal.Delete(entity);
        }

        public DatabasePage Get(int id)
        {
            return _databaseDal.Get(dp => dp.Id == id);
        }

        public List<DatabasePage> GetList()
        {
            return _databaseDal.GetList();
        }

        public void Update(DatabasePage entity)
        {
          _databaseDal.Update(entity);
        }
    }
}
