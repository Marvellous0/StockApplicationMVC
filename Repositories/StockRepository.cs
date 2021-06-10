using StockAppMVC.Models;
using StockAppMVC.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace stockapplication.repositories
{
    public class StockRepository : IStockRepository
    {
    
        private readonly StockDbContext _dbContext;

        public StockRepository(StockDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        //public async Task AddCategory(Category category)
        //{
        //    await _dbContext.AddAsync(category);
        //    await _dbContext.SaveChangesAsync();
        //}

        public Stock AddStock(Stock stock)
        {
            _dbContext.Stocks.Add(stock);
            _dbContext.SaveChanges();
            return stock;
        }

        public Stock FindById(int id)
        {
            return _dbContext.Stocks.Find(id);
        }

        public void UpdateStock(int id)
        {
            var stock = FindById(id);
            {
                if (stock != null)
                {
                    _dbContext.Stocks.Update(stock);
                    _dbContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            var stock = FindById(id);
            {
                if (stock != null)
                {
                    _dbContext.Stocks.Remove(stock);
                    _dbContext.SaveChanges();
                }
            }
        }

        public List<Stock> GetAllStocks()
        {
            return _dbContext.Stocks.ToList();
        }
    }

}


