using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterReserveringenAPI.Models
{
    public class Reservering
    {
        [Key]
        public int ReserveringId { get; set; }
        [Required]
        public string Naam { get; set; }
        public int? KlantId { get; set; }
        public Klant Klant { get; set; }
        public bool Bezet { get; set; }
    }
}
