using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;

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

    }
}
