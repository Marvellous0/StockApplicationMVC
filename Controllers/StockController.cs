//using Microsoft.AspNetCore.Mvc;
//using StockAppMVC.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace StockAppMVC.Controllers
//{
//    public class StockController : Controller
//    {
//        private readonly IStockRepository _stockRepository;

//        public StockController(IStockRepository stockRepository)
//        {
//            _stockRepository = stockRepository;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpGet]
//        public IActionResult Create()
//        {
//            var model = new StockViewModel();
//            return View(model);
//        }

//        [HttpPost]
//        public IActionResult Create(CategoryViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                var category = new Category
//                {
//                    Id = model.Id,
//                    Name = model.Name,
//                    CreatedAt = model.CreatedAt
//                };
//                _categoryRepository.AddCategory(category);
//                return RedirectToAction("Index");
//            }
//            return View();
//        }
//    }
//}
