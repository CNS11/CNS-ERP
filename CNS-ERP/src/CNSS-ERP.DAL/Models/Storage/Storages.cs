﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Storage
{
    public class Storages
    {

        public int StorageId { get; set; }

        [Required(ErrorMessage = "Pole miasto jest wymagane.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pole ulica jest wymagane.")]
        public string Street { get; set; }

        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "Pole kod pocztowy jest wymagane.")]
        public string Postal_code { get; set; }
        [Required]
        public string Street_address { get; set; }

        [Required]
        public string Suite { get; set; }
    }
}
