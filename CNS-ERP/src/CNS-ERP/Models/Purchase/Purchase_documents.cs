﻿using CNSS_ERP.DAL.Models.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Purchase
{
    public class Purchase_documents
    {
        [Key]
        public string Sales_invoiceId { get; set; }


        [Required]
        public string ContractorsRefId { get; set; }

        [Required]
        [ForeignKey("ContractorsRefId")]
        public virtual Contractors Contractor { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Creation_date { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Payment_date { get; set; }

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
        public string Pay_methodsRefId { get; set; }

        [Required]
        [ForeignKey("Pay_methodsRefId")]
        public virtual Pay_methodsinvoice Pay_method { get; set; }
    }
}
