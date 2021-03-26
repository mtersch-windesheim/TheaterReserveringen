using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TheaterApplicatie.Models;

namespace TheaterApplicatie.Data
{
    public class ObjectApiService<TObject> : IObjectService<TObject>
    {
        private readonly HttpClient httpClient;
        private readonly string apiObjectPath = $"/api/{typeof(TObject).Name}";
        public ObjectApiService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:5001/");
        }
        public bool Add(TObject apiObject)
        {
            HttpResponseMessage result = httpClient.PostAsJsonAsync<TObject>(apiObjectPath, apiObject).Result;
            return result.IsSuccessStatusCode;
        }

        public bool Delete(int id)
        {
            HttpResponseMessage result = httpClient.DeleteAsync($"{apiObjectPath}/{id}").Result;
            return result.IsSuccessStatusCode;
        }

        public bool Exists(int id)
        {
            return Get(id) != null;
        }

        public TObject Get(int id)
        {
            TObject apiObject = default(TObject);
            // Ophalen uit API
            var resultaat = httpClient.GetAsync($"{apiObjectPath}/{id}").Result;
            if (resultaat.IsSuccessStatusCode)
            {
                apiObject = resultaat.Content.ReadAsAsync<TObject>().Result;
            }
            return apiObject;
        }

        public List<TObject> GetAll()
        {
            List<TObject> objecten = new List<TObject>();
            // Ophalen uit API
            var resultaat = httpClient.GetAsync(apiObjectPath).Result;
            if (resultaat.IsSuccessStatusCode)
            {
                objecten = resultaat.Content.ReadAsAsync<List<TObject>>().Result;
            }
            return objecten;
        }

        public bool Update(int id, TObject apiObject)
        {
            var resultaat = httpClient.PutAsJsonAsync<TObject>($"{apiObjectPath}/{id}", apiObject).Result;
            return (resultaat.IsSuccessStatusCode);
        }
    }
}
