using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework
{
   public class BlogContext : DbContext
    {

        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<Banner> Banners { get; set; }

    }
}
