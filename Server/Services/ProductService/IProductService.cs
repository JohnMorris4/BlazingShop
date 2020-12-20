using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShopApp.Shared.Models;

namespace BlazorShopApp.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(string categoryUrl);
        Task<Product> GetProduct(int id);
    }
}