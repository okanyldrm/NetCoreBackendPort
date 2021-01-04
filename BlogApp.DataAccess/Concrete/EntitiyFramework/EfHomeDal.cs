using BlogApp.Core.DataAccess.EntityFramework;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework
{
    public class EfHomeDal : EfRepositoryBase<HomePage, BlogContext>, IHomeDal
    {
      
    }
}
