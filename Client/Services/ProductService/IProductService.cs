using System.Collections.Generic;
using BlazorShopApp.Shared.Models;

namespace BlazorShopApp.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        void LoadProducts()
        {
        }
    }
}