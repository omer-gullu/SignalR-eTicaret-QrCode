using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controller
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
        public IActionResult CategoryList()
        {
            var value = _categoryService.TGetListAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = true
            };
            _categoryService.TAdd(category);
            return Ok("Yeni Kategori Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("Kategori kısmı silindi");
        }

		[HttpGet("{id}")]
		public IActionResult GetCategory(int id)
		{
			var value = _categoryService.TGetByID(id);
			return Ok(value);
		}

		[HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            Category category = new Category()
            {
                CategoryID = updateCategoryDto.CategoryID,
                CategoryName = updateCategoryDto.CategoryName,
                Status = true
            };
            _categoryService.TUpdate(category);
            return Ok("Kategori Kısmı Güncellendi");
        }
     
    }
}
