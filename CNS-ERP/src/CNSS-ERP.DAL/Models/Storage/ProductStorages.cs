using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Storage
{
    public class ProductStorages
    {
        [Key]
        public int ProductStoragesId { get; set; }


        [Required]
        public string ProductsRefId { get; set; }

        [Required]
        [ForeignKey("ProductsRefId")]
        public virtual Products Product { get; set; }

        [Required]
        public Decimal Quantity { get; set; }
        [Required]
        public string UnitsRefId { get; set; }

        [Required]
        [ForeignKey("UnitsRefId")]
        public virtual Units Unit { get; set; }



    }
}
