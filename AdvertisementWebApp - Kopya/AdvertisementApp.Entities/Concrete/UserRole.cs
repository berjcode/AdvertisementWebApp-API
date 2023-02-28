using AdvertisementApp.Core.Entities.Abstract;
using AdvertisementApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Entities.Concrete
{
    public class UserRole: EntityBase, IEntity
    {
        public string  Name { get; set; }
        public string Description { get; set; }

        // bir rol'ün birden fazla kullanıcısı olabilir.

        public ICollection<User> Users{ get; set; }

    }
}
