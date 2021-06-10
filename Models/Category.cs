using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockAppMVC.Models
{
    public class Category : BaseEntity
    {
        [Required, MaxLength(50)]
  
        public string Name { get; set; }

        public List<Stock> Stocks { get; set; } = new List<Stock>();
    }
}
