using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework
{
   public class BlogContext : DbContext
    {

        //Need Empty Consructor 
        public BlogContext() 
        {
        }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        //----OLD----
        //Connection-String (N-Tier Connection non-parameter ctor please :D ^ )
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5433; Database=myDataBase; User Id=postgres; Password=1234; Integrated Security=true;Pooling=true;");
        }

        public DbSet<Banner> Banners { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Project> Projects { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
        }




    }
}
