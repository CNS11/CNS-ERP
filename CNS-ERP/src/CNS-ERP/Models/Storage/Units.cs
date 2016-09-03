using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Storage
{
    public class Units
    {
        [Key]
        public string UnitId { get; set; }

        public string Description { get; set; }
    }
}
