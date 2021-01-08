using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
    public interface IAboutPageService
    {

        List<AboutPage> GetList();

        AboutPage Get(int id);

        void Add(AboutPage entity);

        void Update(AboutPage entity);

        void Delete(AboutPage entity);

    }
}
