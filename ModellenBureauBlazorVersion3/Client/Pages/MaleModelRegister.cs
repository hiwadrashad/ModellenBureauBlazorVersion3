using Data.Models;
using Microsoft.AspNetCore.Components;
using ModellenBureauBlazorVersion3.Client.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion2.Pages
{
    public partial class MaleModelRegister
    {
        [Inject]
        public IAdminDataService _adminDataService { get; set; }
        [Inject]
        public IClientDataService _clientDataService { get; set; }
        [Inject]
        public IEventDataService _eventDataService { get; set; }
        [Inject]
        public IFemaleModelDataService _femaleModelDataService { get; set; }
        [Inject]
        public IMaleModelDataService _maleModelDataService { get; set; }

        ClientModel loginmodel = new ClientModel();

        [Inject]
        public NavigationManager navmanager { get; set; }

        public async void Register()
        {
            MaleModeModel model = new MaleModeModel();
            model.Username = loginmodel.UserName;
            model.Password = loginmodel.Password;
            await _maleModelDataService.AddMaleModel(model);
            navmanager.NavigateTo("/");
        }
        public void GoToLogin()
        {
            navmanager.NavigateTo("/");
        }

        public void GoToMaleRegister()
        {
            navmanager.NavigateTo("/malemodelregister");
        }

        public void GoToFemaleRegister()
        {
            navmanager.NavigateTo("/femalemodelregister");
        }

        public void GoToClientRegister()
        {
            navmanager.NavigateTo("/register");
        }

    }
}
