using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Core.Entity;

namespace Entities.Concrete
{
   public class EventCategory : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Event> Events { get; set; }


    }
}
