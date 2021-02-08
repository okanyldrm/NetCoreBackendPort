using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BlogApp.Core.Entity;

namespace Entities.Concrete
{
    public class Blog : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string MiniTitle { get; set; }
        public string Content { get; set; }
        public string Title2 { get; set; }
        public string Content2 { get; set; }
        public string ImageUrl { get; set; }

    }
}
