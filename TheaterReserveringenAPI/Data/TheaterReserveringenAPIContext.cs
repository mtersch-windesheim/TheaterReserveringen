using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheaterReserveringenAPI.Models;

namespace TheaterReserveringenAPI.Data
{
    public class TheaterReserveringenAPIContext : DbContext
    {
        public TheaterReserveringenAPIContext (DbContextOptions<TheaterReserveringenAPIContext> options)
            : base(options)
        {
        }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Reservering> Reserveringen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed-data een beetje netter: vanuit de migration, via de DbContext
            modelBuilder.Entity<Klant>(b =>
            {
                b.HasData(
                    new TheaterReserveringenAPI.Models.Klant() { KlantId = 1, Naam = "Pietje Puk", Adres = "Sesamstraat 1", Woonplaats = "Hilversum", Email = "piet@puck.nl" },
                    new TheaterReserveringenAPI.Models.Klant() { KlantId = 2, Naam = "Klaas Vaak", Adres = "Sesamstraat 2", Woonplaats = "Hilversum", Email = "klaas@puck.nl" },
                    new TheaterReserveringenAPI.Models.Klant() { KlantId = 3, Naam = "Gerda Grutjes", Adres = "Sesamstraat 3", Woonplaats = "Hilversum", Email = "Gerda@puck.nl" }
                );
            });
            modelBuilder.Entity<Reservering>(res =>
            {
                int idCounter = 0;
                foreach (char rij in "ABCDE")
                {
                    for (int stoel = 1; stoel <= 6; stoel++)
                    {
                        idCounter++;
                        res.HasData(new TheaterReserveringenAPI.Models.Reservering() { ReserveringId = idCounter, Naam = $"{rij}{stoel}", Bezet = false });
                    }
                }
            });
        }
    }
}
