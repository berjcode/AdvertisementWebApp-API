using AdvertisementApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Data.Concrete.Entityframework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c=> c.Id ).ValueGeneratedOnAdd();

            builder.Property(c=> c.Name).IsRequired().HasMaxLength(50);

            builder.Property(c =>c.Description).IsRequired().HasMaxLength(250);
            //


            //
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();

            //

            builder.Property(a => a.IsActive).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired(true);

            builder.Property(a => a.Note).HasMaxLength(300);

            builder.ToTable("Categories");


        }
    }
}
