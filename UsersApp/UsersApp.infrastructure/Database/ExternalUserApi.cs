using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using UserApp.application.Common;
using UserApp.application.DTOs.Users;

namespace UsersApp.infrastructure.Database
{
    public class ExternalUserApi : IExternalUserApi
    {
        private readonly HttpClient _httpClient;

        public ExternalUserApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ExternalUserDto>> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ExternalUserDto>>(
                "https://jsonplaceholder.typicode.com/users"
            ) ?? new List<ExternalUserDto>();
        }
    }
}
