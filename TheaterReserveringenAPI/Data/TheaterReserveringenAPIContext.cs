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
    }
}
