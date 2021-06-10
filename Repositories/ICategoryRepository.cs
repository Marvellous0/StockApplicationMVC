using StockAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAppMVC.Repositories
{
    public interface ICategoryRepository
    {
        public Category AddCategory(Category category);
        public Category FindById(int id);
        public Category UpdateCategory(Category category);
        public void Delete(int id);
        public List<Category> GetCategories();
     }
   
}
