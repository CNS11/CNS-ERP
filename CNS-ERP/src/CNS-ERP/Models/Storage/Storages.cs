using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models.Storage
{
    public class Storages
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StorageId { get; set; }

        [Required(ErrorMessage = "Pole miasto jest wymagane.")]
        [MinLength(3, ErrorMessage = "Pole miasto musi mieć co najmniej 3 znaki")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pole ulica jest wymagane.")]
        [MinLength(3, ErrorMessage = "Pole Ulica musi mieć co najmniej 3 znaki")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Pole kod pocztowy jest wymagane.")]
        [RegularExpression(@"^\d{2}(-\d{3})?$", ErrorMessage = "Kod pocztowy musi być w formacie XX-XXX")]

        [DataType(DataType.PostalCode)]
        public string Postal_code { get; set; }
        [Required(ErrorMessage = "Pole adres jest wymagane.")]
        public string Street_address { get; set; }

        public string Suite { get; set; }

        public string Name { get; set; }
    }
}
