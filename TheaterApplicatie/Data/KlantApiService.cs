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

        public KlantApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
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
            List<Klant> klanten = new List<Klant>();
            HttpResponseMessage responseMessage = httpClient.GetAsync("/api/Klanten").Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                // Voeg package Microsoft.AspNet.WebApi.Client toe voor extension method ReadAsAsync<T>()
                klanten = responseMessage.Content.ReadAsAsync<List<Klant>>().Result;
            }
            return klanten;
        }

        public bool Update(Klant klant)
        {
            throw new NotImplementedException();
        }
    }
}
