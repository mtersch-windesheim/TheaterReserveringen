using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
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
        public void Add(Klant klant)
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
            string returnString = httpClient.GetAsync("/api/Klanten").Result.Content.ReadAsStringAsync().Result;
            return JsonSerializer.Deserialize<List<Klant>>(
                returnString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }
            );
        }

        public bool Update(Klant klant)
        {
            throw new NotImplementedException();
        }
    }
}
