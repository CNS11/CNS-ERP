using System.ComponentModel.DataAnnotations;

namespace CNSS_ERP.DAL.Models.Sales
{
    public class Contractors
    {
        [Key]
        [Required]
        public string ContractorsId { get;set;}

        [Required(ErrorMessage = "Pole numer NIP jest wymagane.")]
        public string Vat_number { get; set; }
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