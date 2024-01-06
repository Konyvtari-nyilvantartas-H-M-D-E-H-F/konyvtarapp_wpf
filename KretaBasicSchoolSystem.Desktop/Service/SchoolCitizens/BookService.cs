using konyvtarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace konyvtarMVVM.Service.SchoolCitizens
{
    public class BookService : IBookService
    {
        private readonly HttpClient? _httpClient;

        public BookService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory is not null)
            {
                _httpClient = httpClientFactory.CreateClient("BooksApi");
            }
        }
        public async Task<List<Book>> SelectAllBook()
        {
            if (_httpClient is object)
            {
                List<Book>? result = await _httpClient.GetFromJsonAsync<List<Book>>("api/Book");
                if (result is object)
                    return result;
            }
            return new List<Book>();
        }
    }
}
