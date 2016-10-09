using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNSS_ERP.DAL.Models
{
    public class UserAdditionalInfos
    {
        [Key]
        public int UserAdditionalInfosId { get; set; }
        [Required(ErrorMessage ="Pole Imię jest wyamagane")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole Nazwisko jest wymagane.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Pole Miasto jest wymagane.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pole Ulica jest wymagane.")]
        public string Street { get; set; }
        [NotMapped]
        public Position Position { get; set; }


    }
    public enum Position
    {
        Sprzedawca,Magazynier,Kierownik
    }
}
