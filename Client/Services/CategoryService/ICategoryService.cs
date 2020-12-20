using System.Collections.Generic;
using BlazorShopApp.Shared.Models;

namespace BlazorShopApp.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        void LoadCategories();
    }
}