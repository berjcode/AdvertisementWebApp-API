using Advertisement.API.Models;
using AdvertisementApp.Entities.Concrete;
using AdvertisementApp.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Advertisement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var result = await  _categoryService.GetAll();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(CategoryCreatedModel category)
        {
            _categoryService.CategoryAdd(new Category
            {
                Name = category.Name,
                Description = category.Description,
            });

            return Ok();
        }

    
    }
}
