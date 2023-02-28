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

    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=> c.Id).ValueGeneratedOnAdd();
            builder.Property(c=> c.Text).IsRequired().HasMaxLength(300);
            

            


            //
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.UpdatedDate).IsRequired();

            //

            builder.Property(c => c.IsActive).IsRequired(true);
            builder.Property(c => c.IsDeleted).IsRequired(true);

            builder.Property(c => c.Note).HasMaxLength(300);
            builder.HasOne<Advertisement>(c => c.Advertisements).WithMany(a => a.Comments).HasForeignKey(c => c.AdvertisementId);
            builder.HasOne<User>(c => c.Users).WithMany(u => u.Comments).HasForeignKey(c => c.UserId);
            builder.ToTable("Comments");




        }
    }
}
