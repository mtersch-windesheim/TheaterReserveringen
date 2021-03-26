using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterApplicatie.Models;

namespace TheaterApplicatie.Data
{
    public class KlantMemoryService : IObjectService<Klant>
    {
        private List<Klant> _klanten = new List<Klant>()
        {
            new Klant(){ KlantId=1,Naam="Test", Adres="Straat 1",Woonplaats="Hier", Email="test@test.nl"},
            new Klant(){ KlantId=2,Naam="Test2", Adres="Straat 2",Woonplaats="Hier", Email="test2@test.nl"},
        };
        public bool Add(Klant klant)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Klant Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Klant> GetAll()
        {
            return _klanten;
        }

        public bool Update(int id, Klant klant)
        {
            throw new NotImplementedException();
        }
    }
}
