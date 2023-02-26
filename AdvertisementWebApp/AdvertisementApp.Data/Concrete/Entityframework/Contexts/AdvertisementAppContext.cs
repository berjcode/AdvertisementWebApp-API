using AdvertisementApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Data.Concrete.Entityframework.Contexts
{
    public class AdvertisementAppContext :DbContext
    {

        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment>  Comments { get; set; }

        public DbSet<User>  Users{ get; set; }

        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= berjcode; Initial Catalog= AdvertisementApp; Integrated Security=true;");
        }
    }
}
