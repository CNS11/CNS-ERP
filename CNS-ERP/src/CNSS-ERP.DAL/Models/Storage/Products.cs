using CNSS_ERP.DAL.Models.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Storage
{
    public class Products
    {
        [Key]
        [Required]
        public string ProductId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string EAN_code { get; set; }

        [Required]
        public string UnitsRefId { get; set; }

        [Required]
        [ForeignKey("UnitsRefId")]
        public virtual Units Unit { get; set; }


        [Required]
        public string Tax_ratesRefId { get; set; }

        [Required]
        [ForeignKey("Tax_ratesRefId")]
        public virtual Tax_rates Tax_rate { get; set; }
        public int Product_categoryRefId { get; set; }

        [Required]
        [ForeignKey("Product_categoryRefId")]
        public virtual Product_categories Product_category { get; set; }
    }
}
