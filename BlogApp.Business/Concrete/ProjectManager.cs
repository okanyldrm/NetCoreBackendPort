using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class ProjectManager : IProjectService
    {

        private readonly IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void Add(Project entity)
        {
            _projectDal.Add(entity);
        }

        public void Delete(Project entity)
        {
            _projectDal.Delete(entity);
        }

        public Project Get(int id)
        {
            return _projectDal.Get(p => p.Id == id);
        }

        public List<Project> GetList()
        {
            return _projectDal.GetList();
        }

        public void Update(Project entity)
        {
            _projectDal.Update(entity);
        }
    }
}
