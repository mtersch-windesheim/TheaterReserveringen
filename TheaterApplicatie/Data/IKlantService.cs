using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterApplicatie.Models;

namespace TheaterApplicatie.Data
{
    // Deze nu buiten gebruik
    public interface IKlantService
    {
        public List<Klant> GetAll();
        public Klant Get(int id);
        public bool Add(Klant klant);
        public bool Delete(int id);
        public bool Update(int id, Klant klant);
        public bool Exists(int id);
    }
}
