using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IFeatureService
    {


        List<Feature> GetList();

        Feature Get(int id);

        void Add(Feature entity);

        void Update(Feature entity);

        void Delete(Feature entity);

    }
}
