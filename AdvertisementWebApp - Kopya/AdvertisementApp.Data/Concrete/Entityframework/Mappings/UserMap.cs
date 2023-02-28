using AdvertisementApp.Core.Entities.Abstract;
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

    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50);

            //uniq  
            builder.HasIndex(x=> x.Email ).IsUnique();

            builder.Property(x=> x.UserName).IsRequired();

            builder.Property(x=> x.UserName).HasMaxLength(20);


            builder.HasIndex(x=> x.UserName).IsUnique();    


            //


            builder.Property( x => x.PasswordHash).IsRequired();

            builder.Property(x => x.PasswordHash).HasColumnType("VARBINARY(500)");  //MD5



            //

            builder.Property(x => x.Description).HasMaxLength(500);

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(35);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(35);

            builder.Property(x => x.Photo).IsRequired();
            builder.Property(x => x.Photo).HasMaxLength(250);

            //
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired();

            //

            builder.Property(x => x.IsActive).IsRequired(true);
            builder.Property(x =>x.IsDeleted).IsRequired(true);

            builder.Property(x => x.Note).HasMaxLength(300);


            builder.HasOne<UserRole>(u => u.UserRole).WithMany(u => u.Users).HasForeignKey(u => u.RoleId);






        }
    }
}
