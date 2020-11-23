using BlogApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Banner : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Title2Content { get; set; }
        public string Title3 { get; set; }
        public string Title3Content { get; set; }
        public string Title4 { get; set; }
        public string Title4Content { get; set; }
        public string One { get; set; }
        public string Two { get; set; }
        public string Three { get; set; }
        public string Four { get; set; }

    }
}
