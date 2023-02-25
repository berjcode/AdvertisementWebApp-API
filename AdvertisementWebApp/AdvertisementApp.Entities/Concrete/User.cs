using AdvertisementApp.Core.Entities.Abstract;
using AdvertisementApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Entities.Concrete
{
    public class User : EntityBase, IEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }   
        public string UserName { get; set; }


        public byte[] PasswordHash { get; set; }



        public int RoleId { get; set; }

        public UserRole UserRole { get; set; }


        public string Photo { get; set; }

        public string Description { get; set; }


        public ICollection<Advertisement> Advertisements { get; set; }


        public ICollection<Comment> Comments { get; set; }

    }
}
