using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Product_Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Product name is not correct")]
        public string Product_Name { get; set; }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product Price is required")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Product Price must be a number")]
        [Range(0, int.MaxValue, ErrorMessage = "Price must be a non-negative number")]
        public int Product_Price { get; set; }

        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product Stock is required")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Product Stock must be a number")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock must be a non-negative number")]
        public int Product_Stock { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 100 characters")]
        public string Category_Name { get; set; }

        [DisplayName("Provider Id")]
        [Required(ErrorMessage = "Provider Id is required")]
        public int Provider_Id { get; set; }

    }
}
