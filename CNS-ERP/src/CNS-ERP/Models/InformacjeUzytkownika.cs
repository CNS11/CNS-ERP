using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNS_ERP.Models
{
    public class InformacjeUzytkownika
    {
        [Key]
        public int InformacjeUzytkownikaId { get; set; }
        [Required(ErrorMessage ="Pole Imię jest wyamagane")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Pole Nazwisko jest wyamagane")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Pole Miasto jest wyamagane")]
        public string Miasto { get; set; }
        [Required(ErrorMessage = "Pole Ulica jest wyamagane")]
        public string Ulica { get; set; }
        [Required]
        public Stanowisko Stanowisko { get; set; }


    }
    public enum Stanowisko
    {
        Sprzedawca,Magazynier,Kierownik
    }
}
