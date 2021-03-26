using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterReserveringenAPI.Models
{
    public class Klant
    {
        [Key]
        public int? KlantId { get; set; }
        [Required]
        [MinLength(2)]
        public string Naam { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Woonplaats { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public ICollection<Reservering> Reserveringen { get; set; }
    }
}
