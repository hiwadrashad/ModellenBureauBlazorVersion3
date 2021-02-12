using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public class ClientDataService : IClientDataService
    {
        private readonly HttpClient _httpClient;

        public ClientDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<ClientModel> AddClient(ClientModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Clients", modelJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<ClientModel>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task DeleteClient(string id)
        {
            await _httpClient.DeleteAsync($"api/Clients/{id}");
        }

        public async Task<IEnumerable<ClientModel>> GetAllClients()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ClientModel>>(await _httpClient.GetStreamAsync($"api/Clients"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<ClientModel> GetClientModelDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<ClientModel>(await _httpClient.GetStreamAsync($"api/Clients/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }); ;
        }

        public async Task UpdateClientModel(ClientModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/Clients", modelJson);
        }
    }
}
