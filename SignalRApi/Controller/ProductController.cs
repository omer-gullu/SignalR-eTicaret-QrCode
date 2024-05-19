using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _productService.TGetListAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            Product product = new Product()
            {
                ProductName = createProductDto.ProductName,
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                ProductStatus = true
            };
            _productService.TAdd(product);
            return Ok("Ürün eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün silindi");
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            Product product = new Product()
            {
                ProductID = updateProductDto.ProductID,
                ProductName = updateProductDto.ProductName,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductStatus = true
            };
            _productService.TUpdate(product);
            return Ok("Ürün güncellendi");
        }
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
    }
}
