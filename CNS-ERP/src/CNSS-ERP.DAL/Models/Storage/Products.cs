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
        public string ProductId { get; set; }

        public string Description { get; set; }

        public string EAN_code { get; set; }


        [Required]
        public string Tax_ratesRefId { get; set; }

        [Required]
        [ForeignKey("Tax_ratesRefId")]
        public virtual Tax_rates Tax_rate { get; set; }
    }
}
