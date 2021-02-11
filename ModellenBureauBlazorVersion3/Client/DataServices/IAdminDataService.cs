using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.DataServices
{
    public interface IAdminDataService
    {
       public Task<IEnumerable<string>> GetAllAdmins();
    }
}
