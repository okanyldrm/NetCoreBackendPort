using BlogApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
   public class HomePage : IEntity
    {
        public int Id { get; set; }
        public string MainTitle { get; set; }
        public string Title { get; set; }
        public string MiniTitle { get; set; }
        public string TitleContent { get; set; }
        public string Title2 { get; set; }
        public string MiniTitle2 { get; set; }
        public string Title2Content { get; set; }

        public string Downloads { get; set; }
     
        public string HappyClient { get; set; }
   
        public string ProjectDone { get; set; }
       
        public string HoursSpent { get; set; }
    }
}
