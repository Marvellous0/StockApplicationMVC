using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockAppMVC.Models
{
    public class Stock : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SellingPrice { get; set; }

        [Required, MaxLength(50)]
        public string SKU { get; set; }

        public int Quantity { get; set; }

        [MaxLength(15)]
        public string Variation { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
