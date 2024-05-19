using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;

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
            return Ok();
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            return Ok();
        }
    }
}
