using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheaterApplicatie.Models;

namespace TheaterApplicatie.Data
{
//    public class KlantMemoryService : IKlantService
    public class KlantMemoryService : IObjectService<Klant>
    {
        private readonly Dictionary<int, Klant> _klanten;
        public KlantMemoryService()
        {
            _klanten = new Dictionary<int, Klant>();
            _klanten.Add(1, new Klant() { KlantId = 1, Naam = "Pietje Puk", Adres = "Plein 1", Woonplaats = "Dorp", Email = "piet@test.test" });
            _klanten.Add(2, new Klant() { KlantId = 2, Naam = "Test de Tester", Adres = "Plein 2", Woonplaats = "Dorp", Email = "test@test.test" });
        }
        public void Add(Klant klant)
        {
            if (!_klanten.ContainsKey(klant.KlantId))
                _klanten.Add(klant.KlantId, klant);
        }

        public bool Delete(int id)
        {
            return _klanten.Remove(id);
        }

        public bool Exists(int id)
        {
            return _klanten.ContainsKey(id);
        }

        public Klant Get(int id)
        {
            return _klanten.GetValueOrDefault(id);
        }

        public List<Klant> GetAll()
        {
            return _klanten.Values.ToList();
        }

        public bool Update(Klant klant)
        {
            if (_klanten.ContainsKey(klant.KlantId))
            {
                _klanten[klant.KlantId] = klant;
                return true;
            }
            else
                return false;
        }
    }
}
