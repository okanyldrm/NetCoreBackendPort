using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace BlogApp.Business.Abstract
{
    public interface IDatabaseService
    {



        void Add(Database entity);
        void Delete(Database entity);
        void Update(Database entity);
        Database Get(int id);
        List<Database> GetList();


    }
}
