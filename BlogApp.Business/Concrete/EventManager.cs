using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using Entities.ComplexType;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;

namespace BlogApp.Business.Concrete
{
    public class EventManager : IEventService
    {

        private readonly IEventDal _eventDal;

       

      

       
        public EventManager(IEventDal eventDal )
        {
            _eventDal = eventDal;
           
        }

        public void Add(Event entity)
        {
            
            entity.Date = entity.Date.AddDays(1);
            var time = entity.Time.Split(':');
            var hours = System.Convert.ToInt32(time[0]);
            var minutesString = time[1].Substring(0, 2);
            var minutes = System.Convert.ToInt32(minutesString);
            var date = new DateTime(entity.Date.Year, entity.Date.Month, entity.Date.Day, hours, minutes, 0);
            entity.Date = date;
            _eventDal.Add(entity);
        }

        public void Delete(Event entity)
        {
            _eventDal.Delete(entity);
        }

        public void Update(Event entity)
        {
            _eventDal.Update(entity);
        }

        public Event Get(int id)
        {
            return _eventDal.Get(e => e.Id.Equals(id));
        }


        public Event GetByStringId(string id)
        {
            return _eventDal.GetByStringId(gsi => gsi.Id == id);
        }

        public int GetCountEvent()
        {
            var count = GetList().Count;
            return count;
        }

        public List<EventCategoryDTO> GetEventCategory()
        {
            return _eventDal.GetEventCategory();
        }

        public List<EventCategoryDTO> GetWeekEvent()
        {
            var currentdDate = DateTime.Now;

            return _eventDal.GetWeekEvent(currentdDate);
        }


        public List<Event> GetList()
        {
            return _eventDal.GetList();
        }

    
    }
}
