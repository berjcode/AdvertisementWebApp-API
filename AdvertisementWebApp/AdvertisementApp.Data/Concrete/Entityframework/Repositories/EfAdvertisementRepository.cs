using AdvertisementApp.Core.Data.Concrete.Entityframework;
using AdvertisementApp.Data.Abstract;
using AdvertisementApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Data.Concrete.Entityframework.Repositories
{
    public class EfAdvertisementRepository : EfEntityRepositoryBase<Advertisement>, IAdvertisement
    {

        //efentityrepositorytbase constructor dbcontext var.
        public EfAdvertisementRepository(DbContext context) : base(context)
        {
        }
    }
}
