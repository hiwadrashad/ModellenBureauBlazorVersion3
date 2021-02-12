using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public class MaleModelDataService :IMaleModelDataService
    {
        private readonly HttpClient _httpClient;

        public MaleModelDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<MaleModeModel> AddMaleModel(MaleModeModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/MaleModel", modelJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<MaleModeModel>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task DeleteMaleModel(string id)
        {
            await _httpClient.DeleteAsync($"api/MaleModel/{id}");
        }

        public async Task<IEnumerable<MaleModeModel>> GetAllMaleModels()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<MaleModeModel>>(await _httpClient.GetStreamAsync($"api/MaleModel"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<MaleModeModel> GetMaleModelDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<MaleModeModel>(await _httpClient.GetStreamAsync($"api/MaleModel/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }); ;
        }

        public async Task UpdateMaleModel(MaleModeModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/MaleModel", modelJson);
        }
    }
}
