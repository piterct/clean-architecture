using CleanArchitecture.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CleanAchitecture.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);

            return Ok(product);
        }
    }
}
