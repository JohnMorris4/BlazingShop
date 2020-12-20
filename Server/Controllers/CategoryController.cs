using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShopApp.Server.Services.CategoryService;
using BlazorShopApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShopApp.Server.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategories());

        }
    }
}