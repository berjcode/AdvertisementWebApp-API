using AdvertisementApp.Data.Abstract.UnitOfWork;
using AdvertisementApp.Entities.Concrete;
using AdvertisementApp.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Services.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly IUnitOfWork _unitOfWork;

      

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    

        public async Task<List<Category>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync();

            return (List<Category>)categories;
        }

        public Category CategoryAdd(Category category)
        {
            var category1 = _unitOfWork.Categories.AddAsync(category);
               
             _unitOfWork.SaveAsync();


            return category;
        }

     

    }
}
