using System.Collections.Generic;
using KretaBasicSchoolSystem.Desktop.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.Service.SchoolCitizens
{
    public class UserService : IUserService
    {
        private readonly HttpClient? _httpClient;
     
        public UserService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory is not null)
            {
                _httpClient = httpClientFactory.CreateClient("BooksApi");
            }
        }
        public async Task<List<User>> SelectAllUser()
        {
            if (_httpClient is object)
            {
                List<User>? result = await _httpClient.GetFromJsonAsync<List<User>>("api/User");
                if (result is object)
                    return result;
            }
            return new List<User>();
        }

    }
}
