using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShopApp.Shared.Models;

namespace BlazorShopApp.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}