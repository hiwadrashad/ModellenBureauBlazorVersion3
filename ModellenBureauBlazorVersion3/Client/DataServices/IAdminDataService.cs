using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public interface IAdminDataService
    {
         Task<AdminModel> AddAdmin(AdminModel model);
         Task DeleteAdminModel(string id);
         Task<IEnumerable<AdminModel>> GetAllAdmins();
         Task<AdminModel> GetAdminModelDetails(string id);
         Task UpdateAdminModel(AdminModel model);
    }
}
