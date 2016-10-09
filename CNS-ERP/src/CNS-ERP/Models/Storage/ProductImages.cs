using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Storage
{
    public class ProductImages
    {

        [Required]
        [Key]
        public int ProductImagesId { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public int ProductsRefId { get; set; }
        [ForeignKey("ProductsRefId")]
        public virtual Products Product { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Uploaded_date { get; set; }

    }
}
