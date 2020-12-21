using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShopApp.Server.Services.ProductService;
using BlazorShopApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShopApp.Server.Controllers
{
    
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _productService.GetAllProducts());
        }
        
        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            return Ok(await _productService.GetProduct(id));
        }
    }
}