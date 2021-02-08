using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BlogApp.Core.DataAccess;
using Entities.ComplexType;
using Entities.Concrete;

namespace BlogApp.DataAccess.Abstract
{
    public interface IEventDal : IRepository<Event>
    {

        Event GetByStringId(Expression<Func<Event, bool>> filter = null);

        List<EventCategoryDTO> GetEventCategory();

        List<EventCategoryDTO> GetWeekEvent(DateTime currentdDate);


    }
}
