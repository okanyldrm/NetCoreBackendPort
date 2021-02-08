using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.DataAccess.Concrete.EntitiyFramework.CodeFirstMapping
{
    public class CategoryMap:IEntityTypeConfiguration<EventCategory>
    {
        public void Configure(EntityTypeBuilder<EventCategory> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.ToTable("EventCategories");


        }
    }
}
