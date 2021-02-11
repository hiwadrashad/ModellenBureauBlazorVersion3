using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public class AdminDataService :IAdminDataService
    {
        private readonly HttpClient _httpClient;

        public AdminDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<string>> GetAllAdmins()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<string>>(await _httpClient.GetStreamAsync($"api/Admin"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
