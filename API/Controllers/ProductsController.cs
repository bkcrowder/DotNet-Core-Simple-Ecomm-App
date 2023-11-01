using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductRepository _productRepository;

        public ProductsController(ILogger<ProductsController> logger, IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts() 
        {
            return Ok(await _productRepository.GetProductsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) 
        {
            return Ok(await _productRepository.GetProductByIdAsync(id));
        }

        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            return Ok(await _productRepository.GetProductBrandsAsync());
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            return Ok(await _productRepository.GetProductTypesAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            return await _productRepository.AddProductAsync(product);
        }
    }
}