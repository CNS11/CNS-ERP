﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Sales
{
    public class Receipt_positions
    {
        [Key]
        public int Receipt_positionsId { get; set; }

        [Required]
        public string Sales_ReceiptsRefId { get; set; }

        [Required]
        [ForeignKey("Sales_ReceiptsRefId")]
        public virtual Sales_Receipts Sales_Receipt { get; set; }

        [Required]
        public string ProductId { get; set; }

        [Required]
        public Decimal Quantity { get; set; }

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
