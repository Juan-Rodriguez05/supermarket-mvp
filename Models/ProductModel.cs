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
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Pay mode name must be between 3 and 100 characters")]
        public string Product_Name { get; set; }

        [DisplayName("Price Product")]
        [Required(ErrorMessage = "Pay mode observation is required")]
        [Range(1.0, 1000000, ErrorMessage = "Price must be greater than zero")]
        public int Product_Price { get; set; }

        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product stock is required")]
        [Range(0, 100000, ErrorMessage = "Stock must be greater than or equal to zero")]
        public int Product_Stock { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 100 characters")]
        public string Category_Name { get; set; }

        [DisplayName("Provider Id")]
        [Required(ErrorMessage = "Provider Id is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Pay mode name must be between 3 and 100 characters")]

        public int Provider_Id { get; set; }

    }
}
