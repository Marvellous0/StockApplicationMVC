using StockAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StockAppMVC.Models.CategoryViewModel;

namespace StockAppMVC.Services
{
    public interface ICategoryService
    {
        public Category AddCategory(CreateCategoryViewModel model);
        public Category FindById(int id);
        public Category UpdateCategory(UpdateCategoryViewModel model);
        public void Delete(int id);
        public List<CategoryViewModel> GetCategories();
    }
}
