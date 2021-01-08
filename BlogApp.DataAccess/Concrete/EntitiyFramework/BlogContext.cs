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





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
        }




    }
}
