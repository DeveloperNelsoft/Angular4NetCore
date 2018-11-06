using System;
using System.Collections.Generic;
using System.Linq;
using NelsonCarsalesNetCore.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NelsonCarsalesNetCore.CarsalesLib
{
    public class ApiCaller
    {


        public async Task<List<Car>> ApiCar()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri("http://retail-api.prd.latam.csnglobal.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                JArray carResult =  new JArray();
                var carlist = new List<Car>();
                System.Net.Http.HttpResponseMessage response = await client.GetAsync("demotores/v1/stock/listing");
                if (response.IsSuccessStatusCode)
                {
                    var carRawResult = await response.Content.ReadAsStringAsync();

                    JToken token = JToken.Parse(carRawResult);
                    carResult = (JArray)token.SelectToken("result");
                   
                    foreach (var item in carResult)
                    {
                        string json = JsonConvert.SerializeObject(item);
                        carlist.Add(JsonConvert.DeserializeObject<Car>(json));
                    }

                }
                return carlist;
            }
        }

       
    }
   
}
