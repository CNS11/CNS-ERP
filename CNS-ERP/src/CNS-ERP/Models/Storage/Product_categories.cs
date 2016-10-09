using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Storage
{
    public class Product_categories
    {

        [Key]
        public int Product_categoriesId { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Description { get; set; }


        public int? Master_product_categoryRefId { get; set; }

        [Required]
        [ForeignKey("Master_product_categoryRefId")]
        public virtual Product_categories Master_product_category { get; set; }

       [Required]
        public int Level { get; set; }

    }
}
