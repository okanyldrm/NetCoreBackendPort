using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Entities.ComplexType;
using Entities.Concrete;

namespace BlogApp.Business.Abstract
{
    public interface IEventService
    {

        void Add(Event entity);
        void Delete(Event entity);
        void Update(Event entity);
        Event Get(int id);
        List<Event> GetList();
        Event GetByStringId(string id);
        int GetCountEvent();
        List<EventCategoryDTO> GetEventCategory();
        List<EventCategoryDTO> GetWeekEvent();


    }
}
