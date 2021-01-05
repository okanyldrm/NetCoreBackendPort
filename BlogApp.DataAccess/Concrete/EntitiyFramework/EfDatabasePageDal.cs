using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Core.DataAccess.EntityFramework;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework
{
   public class EfDatabasePageDal : EfRepositoryBase<DatabasePage,BlogContext>, IDatabasePageDal
    {
    }
}
