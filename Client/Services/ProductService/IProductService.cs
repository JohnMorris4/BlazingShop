using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShopApp.Shared.Models;

namespace BlazorShopApp.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task LoadProducts();
    }
}