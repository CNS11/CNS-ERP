using CNSS_ERP.DAL.Models.Sales;
using CNSS_ERP.DAL.Models.Storage;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNSS_ERP.DAL.Models.Purchase
{
    public class Purchase_positions
    {
        [Key]
        public int Purchase_positionsId { get; set; }

        [Required]
        public string Purchase_documentsRefId { get; set; }

        [Required]
        [ForeignKey("Purchase_documentsRefId")]
        public virtual Purchase_documents Purchase_document { get; set; }

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
