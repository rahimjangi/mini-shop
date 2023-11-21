using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWorks _unitOfWorks;

        public ProductsController(IUnitOfWorks unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            await Task.CompletedTask;
            var products = _unitOfWorks.Product.GetAll().ToList();
            return products;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            await Task.CompletedTask;
            return Ok(new { id });
        }
    }
}
