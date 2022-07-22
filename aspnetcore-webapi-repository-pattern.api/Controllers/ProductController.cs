using aspnetcore_webapi_repository_pattern.data.models;
using aspnetcore_webapi_repository_pattern.services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_webapi_repository_pattern.api.Controllers
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

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            return await _productService.GetProductByIdAsync(id);
        }

        public async Task<ActionResult<Product>> CreateProduct()
        {
            var product = new Product
            {
                Name = "Name",
                Description = "Description",
                Price = 99.99m
            };

            return await _productService.AddProductAsync(product);
        }
    }
}
