using BlogApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BackendPage : IEntity
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string MiniTitle { get; set; }
        public string Content { get; set; }
    }
}
