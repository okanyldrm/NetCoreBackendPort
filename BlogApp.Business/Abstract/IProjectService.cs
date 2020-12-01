using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IProjectService
    {



        List<Project> GetList();

        Project Get(int id);

        void Add(Project entity);

        void Update(Project entity);

        void Delete(Project entity);


    }
}
