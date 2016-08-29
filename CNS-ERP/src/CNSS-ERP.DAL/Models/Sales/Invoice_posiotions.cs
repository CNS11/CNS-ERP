using CNSS_ERP.DAL.Models.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Sales
{
    public class Invoice_posiotions
    {
        [Key]
        [Required]
        public int Invoice_posiotionsId { get; set; }
        [Required]
        public string Sales_invoicesRefId { get; set; }

        [Required]
        [ForeignKey("Sales_invoicesRefId")]
        public virtual Sales_invoices Sales_invoice { get; set; }
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

        [Required]
        public Decimal Net_price { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public Decimal Net_value { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public Decimal Tax_value { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public Decimal Gross_value { get; set; }
        [Required]
        public string Tax_ratesRefId { get; set; }

        [Required]
        [ForeignKey("Tax_ratesRefId")]
        public virtual Tax_rates Tax_rate { get; set; }
    }
}
