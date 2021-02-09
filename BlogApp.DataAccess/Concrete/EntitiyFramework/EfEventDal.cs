using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks.Dataflow;
using BlogApp.Core.DataAccess.EntityFramework;
using BlogApp.DataAccess.Abstract;
using Entities.ComplexType;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Configuration;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework
{
    public class EfEventDal :  EfRepositoryBase<Event,BlogContext> , IEventDal
    {

      

        public Event GetByStringId(Expression<Func<Event, bool>> filter = null)
        {
            using var context = new BlogContext();
            {
                return context.Set<Event>().SingleOrDefault(filter);
            }
        }

        public List<EventCategoryDTO> GetEventCategory()
        {
            using (var context = new BlogContext())
            {

                var result = (from e in context.Events
                    join ev in context.EventCategories on e.EventCategoryId equals ev.Id 
                    select new EventCategoryDTO
                    {
                        Id = e.Id,
                        Title = e.Title,
                        Date = e.Date,
                        Color = e.Color,
                        Time = e.Time,
                        EventCategoryName = ev.Name
                    }).ToList();

                return result;
            }
            

        }

        public List<EventCategoryDTO> GetWeekEvent(DateTime currentdDate)
        {
            var onweeklater = currentdDate.AddDays(7);
            using (var context = new BlogContext())
            {


                var result = (from e in context.Events
                    join ec in context.EventCategories on e.EventCategoryId equals ec.Id
                    where e.Date.Day >= currentdDate.Day && e.Date.Day <= onweeklater.Day
                    select new EventCategoryDTO
                    {
                        Id = e.Id,
                        Date = e.Date,
                        Title = e.Title,
                        Color = e.Color,
                        EventCategoryName = ec.Name,
                        Time = e.Time
                    }).ToList();

                return result;
            }

        }

        public GetMonthEventDTO GetMonthEvent()
        {
            var currentdate = DateTime.Now;
            var firstweek = currentdate.AddDays(7);
            var secondweek = currentdate.AddDays(14);
            var thirdweek = currentdate.AddDays(21);
            var fourthweek = currentdate.AddDays(28);

            using (var context = new BlogContext())
            {
                var week1 = (
                    from e1 in context.Events
                    where e1.Date >= currentdate && e1.Date < firstweek
                    select e1
                ).Count();

                var week2 = (
                    from e2 in context.Events
                    where e2.Date >= firstweek && e2.Date < secondweek
                    select e2
                ).Count();

                var week3 = (
                    from e2 in context.Events
                    where e2.Date >= secondweek && e2.Date < thirdweek
                    select e2
                ).Count();

                var week4 = (
                    from e4 in context.Events
                    where e4.Date >= thirdweek && e4.Date < fourthweek
                    select e4
                ).Count();

                var model = new GetMonthEventDTO();
                model.FirstWeek = week1;
                model.SecondWeek = week2;
                model.ThirdWeek = week3;
                model.FourthWeek = week4;

                return model;
            }







        }


        //public List<Event> GetallEventCategory()
        //{
        //    using (var context = new BlogContext())
        //    {
        //        var result = context.Events.Include("EventCategory").Select(e => new Event
        //        {
        //            Id = e.Id, Date = e.Date, Color = e.Color, Time = e.Time, Title = e.Title,
        //            EventCategory = e.EventCategory
        //        }).ToList();
        //        return result;
        //    }
            
        //}
    }
}
