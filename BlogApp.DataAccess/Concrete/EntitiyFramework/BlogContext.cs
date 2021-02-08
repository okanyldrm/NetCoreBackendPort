using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using BlogApp.DataAccess.Concrete.EntitiyFramework.CodeFirstMapping;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework
{
   public class BlogContext :  DbContext 
    {

        private readonly IConfiguration _configuration;

        ////Need Empty Consructor 
        public BlogContext()
        {

        }

        public BlogContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }




        public BlogContext(DbContextOptions<BlogContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        //----OLD----
        //Connection-String (N-Tier Connection non-parameter ctor please :D ^ )
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            
           
        }







        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<BackendPage> BackendPages { get; set; }
        public DbSet<Backend> Backends { get; set; }
        public DbSet<FrontendPage> FrontendPages { get; set; }
        public DbSet<Frontend> Frontends { get; set; }
        public DbSet<DatabasePage> DatabasePages { get; set; }
        public DbSet<Database> Databases { get; set; }
        public DbSet<DevopsPage> DevopsPages { get; set; }
        public DbSet<Devops> Devopses { get; set; }
        public DbSet<WorkPage> WorkPages { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<AboutPage> AboutPages { get; set; }
        public DbSet<BlogPage> BlogPages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
       
     







        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Feature>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Backend>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Frontend>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Database>()
                .Property(dd=>dd.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Devops>()
                .Property(dops=>dops.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Work>()
                .Property(w=>w.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Blog>()
                .Property(bl=>bl.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Event>()
                .Property(ev => ev.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new EventMap());

        }





    }
}
