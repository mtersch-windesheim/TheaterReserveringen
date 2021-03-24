using System.ComponentModel.DataAnnotations;

namespace TheaterApplicatie.Models
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