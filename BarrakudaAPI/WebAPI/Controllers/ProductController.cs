using Application.Interfaces;
using Application.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var products = await _productService.GetAllProducts();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get([FromRoute]int id)
        {
            var products = await _productService.GetProductById(id);

            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody]CreateProductDto productDto)
        {
            await _productService.CreateProduct(productDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromBody]UpdateProductDto productDto, [FromRoute]int id)
        {
            await _productService.UpdateProduct(productDto, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}
