using AdvertisementApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Services.Abstract
{
    public interface ICategoryService
    {

        Task<List<Category>> GetAll();

      Category CategoryAdd(Category category);
    }
}
