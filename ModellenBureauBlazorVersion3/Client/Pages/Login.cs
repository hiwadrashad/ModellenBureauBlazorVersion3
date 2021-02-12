using Data.Models;
using Microsoft.AspNetCore.Components;
using ModellenBureauBlazorVersion3.Client.DataServices;
using System;
using System.Linq;

namespace ModellenBureauBlazorVersion2.Pages
{
    public partial class Login
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

        public ClientModel loginmodel = new ClientModel();

        [Inject]
        public NavigationManager navmanager { get; set; }
        public void GoToRegister()
        {
            navmanager.NavigateTo("/register");
        }


        public async void SuccesfullLogin()
        {
          var adminitem = await _adminDataService.GetAllAdmins();
          var clientitem = await _clientDataService.GetAllClients();
          var malemodelitem = await _maleModelDataService.GetAllMaleModels();
          var femalemodelitem = await _femaleModelDataService.GetAllFemaleModels();  
          if((adminitem.Any(a => a.Username == loginmodel.UserName))&&(adminitem.Any(a => a.Password == loginmodel.Password)))
          {
                navmanager.NavigateTo("/adminmainpage");  
                
          }
          if ((clientitem.Any(a => a.UserName == loginmodel.UserName)) && (clientitem.Any(a => a.Password == loginmodel.Password)))
          {
                navmanager.NavigateTo("/clientmainpage");  
          }
          if ((femalemodelitem.Any(a => a.Username == loginmodel.UserName)) && (femalemodelitem.Any(a => a.Password == loginmodel.Password)))
          {
                navmanager.NavigateTo("/modelmainpage");
          }
            if ((malemodelitem.Any(a => a.Username == loginmodel.UserName)) && (malemodelitem.Any(a => a.Password == loginmodel.Password)))
            {
                navmanager.NavigateTo("/modelmainpage");
            }
          
        }

        public void test()
        {
            MaleModeModel model = new MaleModeModel();
            Console.WriteLine("something");
        }

    }
}
