﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BlogApp.Core.Entity;

namespace Entities.Concrete
{
    public class Work :IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }


    }
}
