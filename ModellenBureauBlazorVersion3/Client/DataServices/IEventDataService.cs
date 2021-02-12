using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public interface IEventDataService
    {
        Task<EventModel> AddEvent(EventModel model);
        Task DeleteEvent(string id);
        Task<IEnumerable<EventModel>> GetAllEvents();
        Task<EventModel> GetEventModelDetails(string id);
        Task UpdateEventsModel(EventModel model);
    }
}
