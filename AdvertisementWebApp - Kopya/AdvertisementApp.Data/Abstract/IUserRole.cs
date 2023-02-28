using AdvertisementApp.Core.Data.Abstract;
using AdvertisementApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Data.Abstract
{
    public interface IUserRole :IEntityRepository<UserRole>
    {
    }
}

