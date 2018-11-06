using System;
using System.Collections.Generic;
using System.Linq;
using NelsonCarsalesNetCore.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NelsonCarsalesNetCore.CarsalesLib
{
    public class ApiCaller
    {


        public async Task<Car> ApiCar()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri("http://retail-api.prd.latam.csnglobal.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                Car product = new Car();
                System.Net.Http.HttpResponseMessage response = await client.GetAsync("demotores/v1/stock/listing");
                if (response.IsSuccessStatusCode)
                {
                    product = await response.Content.ReadAsAsync<Car>();
                }
                return product;
            }
        }

       
    }
   
}
