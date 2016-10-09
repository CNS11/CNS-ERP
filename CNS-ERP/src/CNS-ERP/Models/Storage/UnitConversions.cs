using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Storage
{
    public class UnitConversions
    {

        [Key]
        public int UnitConversionsId { get; set; }
        [Required]
        public string Units_1RefId { get; set; }

        [Required]
        [ForeignKey("Units_1RefId")]
        public virtual Units Unit_1 { get; set; }

        [Required]
        public string Units_2RefId { get; set; }

        [Required]
        [ForeignKey("Units_2RefId")]
        public virtual Units Unit_2 { get; set; }


        public int Precision { get; set; }


        //To convert Unit_1 to Unit_2 use this ratio
        [Required]
        public Decimal Conversion_ratio1_to2;

        //To convert Unit_1 to Unit_2 use this ratio
        [Required]
        public Decimal Conversion_ratio2_to1;
    }
}
