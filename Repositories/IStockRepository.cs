using StockAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAppMVC.Repositories
{
    public interface IStockRepository
    {
        public Stock AddStock(Stock stock);
       
        public Stock FindById(int id);

        public void UpdateStock(int id);

        public void Delete(int id);

        public List<Stock> GetAllStocks();
       
    }
}
