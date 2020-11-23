using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework
{
   public class BlogContext : DbContext
    {

        //public BlogContext(DbContextOptions<BlogContext> options) : base(options) { 
        //}

        //Connection-String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5433; Database=myDataBase; User Id=postgres; Password=1234; Integrated Security=true;Pooling=true;");

        }

        public DbSet<Banner> Banners { get; set; }

    }
}
