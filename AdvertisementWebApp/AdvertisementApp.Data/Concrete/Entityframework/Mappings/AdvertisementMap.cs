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
    public class AdvertisementMap : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> builder)
        {
            // Primarykey belirtiyoruz.
            builder.HasKey(a => a.Id);

            //Identity otomotik artan


            builder.Property(a=> a.Id).ValueGeneratedOnAdd();
            //Title

            builder.Property(a=> a.Title).HasMaxLength(100).IsRequired();
         


            //content

            builder.Property(a=>a.Content).IsRequired(true);


            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");

            //date

            builder.Property(a => a.Date).IsRequired(true);

            //Seo

            builder.Property(a => a.SeoTags).IsRequired(true);



            builder.Property(a=>a.ViewsCount).IsRequired(true);
            builder.Property(a => a.CommentCount).IsRequired(true);

            //PHOTO
            builder.Property(a => a.Photo).HasMaxLength(250);
            builder.Property(a => a.Photo).IsRequired(true);
            builder.Property(a => a.Photo2).HasMaxLength(250);
            builder.Property(a => a.Photo3).HasMaxLength(250);
            builder.Property(a => a.Photo4).HasMaxLength(250);

            //
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a=> a.UpdatedDate).IsRequired();

            //

            builder.Property(a=> a.IsActive).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired(true);

            builder.Property(a => a.Note).HasMaxLength(300);


            // İLİŞKİLER

            //Bir kategorinin birden fazla ilanı olabilir. foreign key  advertisements tablosundaki categorıd

            builder.HasOne<Category>(c => c.Category).WithMany(c => c.Advertisements).HasForeignKey(a=> a.CategoryId);
            builder.HasOne<User>(u => u.User).WithMany(u => u.Advertisements).HasForeignKey(a => a.UserId);
            //

            builder.ToTable("Advertisements");










        }
    }
}
