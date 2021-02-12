using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public interface IMaleModelDataService
    {

        Task<MaleModeModel> AddMaleModel(MaleModeModel model);
        Task DeleteMaleModel(string id);
        Task<IEnumerable<MaleModeModel>> GetAllMaleModels();
        Task<MaleModeModel> GetMaleModelDetails(string id);
        Task UpdateMaleModel(MaleModeModel model);
    }
}
