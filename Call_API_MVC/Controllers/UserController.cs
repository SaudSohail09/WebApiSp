using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Call_API_MVC.Models;
using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using System.Data;

namespace Call_API_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        string baseURL = "http://localhost:44376/";

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            DataTable dt = new DataTable();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await client.GetAsync("Flights");
                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                    dt = JsonConvert.DeserializeObject<DataTable>(results);
                }
                else
                {
                    Console.WriteLine("Error calling web API");
                }
            }
            return View();
        }

      
              
    }
}