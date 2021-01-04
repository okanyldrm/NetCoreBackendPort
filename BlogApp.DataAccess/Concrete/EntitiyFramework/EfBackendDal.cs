using BlogApp.Core.DataAccess.EntityFramework;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework
{
   public class EfBackendDal : EfRepositoryBase<Backend,BlogContext>, IBackendDal
    {
    }
}
