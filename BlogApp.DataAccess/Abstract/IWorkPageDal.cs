using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Core.DataAccess;
using Entities.Concrete;

namespace BlogApp.DataAccess.Abstract
{
    public interface IWorkPageDal :IRepository<WorkPage>
    {
    }
}
