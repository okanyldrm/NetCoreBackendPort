using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DataAccess.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        ////----OLD----
        ////Connection-String (N-Tier Connection non-parameter ctor please :D ^ )
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
