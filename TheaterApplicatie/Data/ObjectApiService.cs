﻿using System;
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
        public ObjectApiService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:5001/");
        }
        public bool Add(TObject klant)
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

        public TObject Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<TObject> GetAll()
        {
            List<TObject> objecten = new List<TObject>();
            // Ophalen uit API
            var resultaat = httpClient.GetAsync($"/api/{typeof(TObject).Name}").Result;
            if (resultaat.IsSuccessStatusCode)
            {
                objecten = resultaat.Content.ReadAsAsync<List<TObject>>().Result;
            }
            return objecten;
        }

        public bool Update(int id, TObject klant)
        {
            throw new NotImplementedException();
        }
    }
}
