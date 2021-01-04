using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class FeatureManager : IFeatureService
    {

        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }


        public void Add(Feature entity)
        {
            _featureDal.Add(entity);
        }

        public void Delete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public Feature Get(int id)
        {
            return _featureDal.Get(f => f.Id == id);
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

        public void Update(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
