using BlogApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TextTitle { get; set; }
        public string TextContent { get; set; }
        public int LanguageId { get; set; }
    }
}
