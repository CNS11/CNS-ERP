using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Sales
{
    public class Tax_rates
    {
        [Key]
        [Required]
        public string Tax_ratesId { get; set; }
        [Required]
        public int Number_value { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Last_changed_date { get; set; }
    }
}
