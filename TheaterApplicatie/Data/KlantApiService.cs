using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TheaterApplicatie.Models;

namespace TheaterApplicatie.Data
{
    public class KlantApiService : IObjectService<Klant>
    {
        private readonly HttpClient httpClient;
        public KlantApiService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:5001/");
        }
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
            List<Klant> klanten = new List<Klant>();
            // Ophalen uit API
            var resultaat = httpClient.GetAsync("/api/Klanten").Result;
            if (resultaat.IsSuccessStatusCode)
            {
                klanten = resultaat.Content.ReadAsAsync<List<Klant>>().Result;
            }
            return klanten;
        }

        public bool Update(int id, Klant klant)
        {
            throw new NotImplementedException();
        }
    }
}
