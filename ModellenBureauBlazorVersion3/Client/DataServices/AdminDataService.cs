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



        public async Task<AdminModel> AddAdmin(AdminModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Admin", modelJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<AdminModel>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task DeleteAdminModel(string id)
        {
            await _httpClient.DeleteAsync($"api/Clients/{id}");
        }

        public async Task<IEnumerable<AdminModel>> GetAllAdmins()
        { 
        return await JsonSerializer.DeserializeAsync<IEnumerable<AdminModel>>(await _httpClient.GetStreamAsync($"api/Admin"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true});
        }

        public async Task<AdminModel> GetAdminModelDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<AdminModel>(await _httpClient.GetStreamAsync($"api/Admin/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }); ;
        }

        public async Task UpdateAdminModel(AdminModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/Admin", modelJson);
        }
    }
}
