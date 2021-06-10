using System;
using System.ComponentModel.DataAnnotations;

namespace StockAppMVC.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class CreateCategoryViewModel
    {
        [Required(ErrorMessage = "Category name is required")]
        [Display(Name = "Category")]
        public string Name { get; set; }
    }

    public class UpdateCategoryViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [Display(Name = "Category")]
        public string Name { get; set; }
    }
}
