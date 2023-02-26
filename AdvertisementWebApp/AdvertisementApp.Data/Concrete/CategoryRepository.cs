﻿using AdvertisementApp.Core.Data.Abstract;
using AdvertisementApp.Core.Data.Concrete.Entityframework;
using AdvertisementApp.Data.Abstract;
using AdvertisementApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Data.Concrete
{
    public class CategoryRepository : EfEntityRepositoryBase<Category>, ICategory
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
