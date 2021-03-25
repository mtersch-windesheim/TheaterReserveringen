using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterApplicatie.Models;

namespace TheaterApplicatie.Data
{
    interface IKlantService
    {
        List<Klant> GetAll();
        Klant Get(int id);
        void Add(Klant klant);
        bool Update(Klant klant);
        bool Delete(int id);
        bool Exists(int id);
    }
}
