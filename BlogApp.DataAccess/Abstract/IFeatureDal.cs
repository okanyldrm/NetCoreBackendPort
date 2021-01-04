using BlogApp.Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Abstract
{
    public interface IFeatureDal : IRepository<Feature>
    {
    }
}
