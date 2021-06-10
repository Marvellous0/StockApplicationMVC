using Microsoft.AspNetCore.Mvc;
using StockApplication.Repositories;
using StockAppMVC.Models;
using StockAppMVC.Repositories;
using StockAppMVC.Services;
using System.Threading.Tasks;
using static StockAppMVC.Models.CategoryViewModel;

namespace StockAppMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categoryList = _categoryService.GetCategories();

            return View(categoryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(CreateCategoryViewModel model)
        {
            _categoryService.AddCategory(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var category = _categoryService.FindById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        public IActionResult Update(int id)
        {
            var category = _categoryService.FindById(id);
          
            var model = new UpdateCategoryViewModel
            {
                Id = category.Id,
                Name = category.Name
            };

            return View(model);

        }
        [HttpPost]
        public IActionResult Update(UpdateCategoryViewModel model)
        {
            _categoryService.UpdateCategory(model);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var category = _categoryService.FindById(id);
            if (category == null)
            {
                return NotFound();
            }

            _categoryService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
