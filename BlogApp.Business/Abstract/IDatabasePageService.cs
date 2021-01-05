using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
    public interface IDatabasePageService
    {
        List<DatabasePage> GetList();

        DatabasePage Get(int id);

        void Add(DatabasePage entity);

        void Update(DatabasePage entity);

        void Delete(DatabasePage entity);


    }
}
