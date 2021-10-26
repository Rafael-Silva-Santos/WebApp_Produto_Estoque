using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebEstoqueApp.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WebEstoqueApp.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        public List<Produto> Produtos { get; private set; } = new List<Produto>();
        string baseUrl = "https://localhost:44369/";
        public async Task OnGetAsync()
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Estoque");
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    Produtos = JsonConvert.DeserializeObject<List<Produto>>(result);
                }
            }
        }
    }
}
