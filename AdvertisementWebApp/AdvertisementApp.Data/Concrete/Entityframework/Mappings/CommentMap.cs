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
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id).ValueGeneratedOnAdd();
            builder.Property(x=> x.Text).IsRequired().HasMaxLength(300);
            builder.HasOne<Advertisement>(a => a.Advertisements).WithMany(a => a.Comments).HasForeignKey(c => c.AdvertisementId);

            builder.HasOne<User>(u=> u.Users).WithMany(u => u.Comments).HasForeignKey(c => c.UserId);


            //
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();

            //

            builder.Property(a => a.IsActive).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired(true);

            builder.Property(a => a.Note).HasMaxLength(300);
            builder.ToTable("Comments");




        }
    }
}
