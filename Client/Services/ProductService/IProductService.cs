using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShopApp.Shared.Models;

namespace BlazorShopApp.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }

        Task LoadProducts(string categoryUrl = null);
        Task<Product> GetProductById(int id);
    }
}