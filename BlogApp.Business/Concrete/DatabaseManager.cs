using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.Business.Concrete
{
    public class DatabaseManager : IDatabaseService
    {

        private readonly IDatabaseDal _databaseDal;

        public DatabaseManager(IDatabaseDal databaseDal)
        {
            _databaseDal = databaseDal;
        }

        public void Add(Database entity)
        {
          _databaseDal.Add(entity);
        }

        public void Delete(Database entity)
        {
           _databaseDal.Delete(entity);
        }

        public void Update(Database entity)
        {
            _databaseDal.Update(entity);
        }

        public Database Get(int id)
        {
            return _databaseDal.Get(d => d.Id == id);
        }

        public List<Database> GetList()
        {
            return _databaseDal.GetList();
        }
    }
}
