using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using konyvtarMVVM.Models;

namespace konyvtarMVVM.Service.SchoolCitizens
{
    public class KiadoService : IKiadoService
    {
        private readonly HttpClient? _httpClient;

        public KiadoService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory is not null)
            {
                _httpClient = httpClientFactory.CreateClient("BooksApi");
            }
        }
        public async Task<List<Kiado>> SelectAllKiado()
        {
            if (_httpClient is object)
            {
                List<Kiado>? result = await _httpClient.GetFromJsonAsync<List<Kiado>>("api/Kiado");
                if (result is object)
                    return result;
            }
            return new List<Kiado>();
        }
    }
}
