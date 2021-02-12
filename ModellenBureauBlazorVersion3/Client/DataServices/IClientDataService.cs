using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public interface IClientDataService
    {
        Task<ClientModel> AddClient(ClientModel model);
        Task DeleteClient(string id);
        Task<IEnumerable<ClientModel>> GetAllClients();
        Task<ClientModel> GetClientModelDetails(string id);
        Task UpdateClientModel(ClientModel model);
    }
}
