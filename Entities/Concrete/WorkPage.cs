using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Core.Entity;

namespace Entities.Concrete
{
   public class WorkPage :IEntity
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string MiniTitle { get; set; }

    }
}
