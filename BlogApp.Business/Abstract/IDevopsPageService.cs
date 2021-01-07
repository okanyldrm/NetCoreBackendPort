using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
    public interface IDevopsPageService
    {

        List<DevopsPage> GetList();

        DevopsPage Get(int id);

        void Add(DevopsPage entity);

        void Update(DevopsPage entity);

        void Delete(DevopsPage entity);
    }
}
