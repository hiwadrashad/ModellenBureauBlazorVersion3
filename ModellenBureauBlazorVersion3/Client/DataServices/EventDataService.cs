using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public class EventDataService : IEventDataService
    {
        private readonly HttpClient _httpClient;

        public EventDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<EventModel> AddEvent(EventModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Events", modelJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<EventModel>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }

        public async Task DeleteEvent(string id)
        {
            await _httpClient.DeleteAsync($"api/Events/{id}");
        }

        public async Task<IEnumerable<EventModel>> GetAllEvents()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<EventModel>>(await _httpClient.GetStreamAsync($"api/Events"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<EventModel> GetEventModelDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<EventModel>(await _httpClient.GetStreamAsync($"api/Events/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }); ;
        }

        public async Task UpdateEventsModel(EventModel model)
        {
            var modelJson = new StringContent(JsonSerializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/Events", modelJson);
        }
    }
}
