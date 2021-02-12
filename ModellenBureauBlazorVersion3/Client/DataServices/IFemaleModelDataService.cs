using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public interface IFemaleModelDataService
    {
        Task<FemaleModelModel> AddFemaleModel(FemaleModelModel model);
        Task DeleteFemaleModel(string id);
        Task<IEnumerable<FemaleModelModel>> GetAllFemaleModels();
        Task<FemaleModelModel> GetFemaleModelDetails(string id);
        Task UpdateFemaleModel(FemaleModelModel model);
    }
}
