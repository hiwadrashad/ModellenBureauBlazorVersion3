using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public class FemaleModelDataService : IFemaleModelDataService
    {
        private readonly HttpClient _httpClient;

        public FemaleModelDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<FemaleModelModel> AddFemaleModel(FemaleModelModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/FemaleModel", modelJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<FemaleModelModel>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task DeleteFemaleModel(string id)
        {
            await _httpClient.DeleteAsync($"api/FemaleModel/{id}");
        }

        public async Task<IEnumerable<FemaleModelModel>> GetAllFemaleModels()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<FemaleModelModel>>(await _httpClient.GetStreamAsync($"api/FemaleModel"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<FemaleModelModel> GetFemaleModelDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<FemaleModelModel>(await _httpClient.GetStreamAsync($"api/FemaleModel/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }); ;
        }

        public async Task UpdateFemaleModel(FemaleModelModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/FemaleModel", modelJson);
        }
    }
}
