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

    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id).ValueGeneratedOnAdd();

            builder.Property( r => r.Name).IsRequired().HasMaxLength(40);

            builder.Property(r => r.Description).IsRequired().HasMaxLength(250);
            //
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();

            //

            builder.Property(a => a.IsActive).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired(true);

            builder.Property(a => a.Note).HasMaxLength(300);

            builder.ToTable("UserRoles");

            //data ekleme

            builder.HasData(new UserRole
            {
                Id = 1,
               Name= "user",
               Description = "user",
               CreatedDate = DateTime.Now,
               UpdatedDate= DateTime.Now,
               IsActive = true,
               IsDeleted = false,
               Note= "user",

            });
        }
    }
}
