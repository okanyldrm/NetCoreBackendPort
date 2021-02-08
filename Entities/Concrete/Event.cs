using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Core.Entity;

namespace Entities.Concrete
{
    public class Event : IEntity
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Color { get; set; }
        public string Time { get; set; }
        public int EventCategoryId { get; set; }
        public EventCategory EventCategory { get; set; }
       
    }
}
