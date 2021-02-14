using Data.Models;
using Logic.StaticResources;
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
                GeneralStaticdata.loggedin = true;
                //GenericStaticdata<AdminModel>.loggedinmodel = adminitem.Where(a => a.Username == loginmodel.UserName).FirstOrDefault(); 
                GeneralStaticdata.currentadminmodel = adminitem.Where(a => a.Username == loginmodel.UserName).FirstOrDefault();
                GeneralStaticdata.currentclientmodel = null;
                GeneralStaticdata.currentfemalemodel = null;
                GeneralStaticdata.currentmalemodel = null;
          }
          if ((clientitem.Any(a => a.UserName == loginmodel.UserName)) && (clientitem.Any(a => a.Password == loginmodel.Password)))
          {
                navmanager.NavigateTo("/clientmainpage");
                GeneralStaticdata.loggedin = true;
                //GenericStaticdata<ClientModel>.loggedinmodel = clientitem.Where(a => a.UserName == loginmodel.UserName).FirstOrDefault();
                GeneralStaticdata.currentadminmodel = null;
                GeneralStaticdata.currentclientmodel = clientitem.Where(a => a.UserName == loginmodel.UserName).FirstOrDefault();
                GeneralStaticdata.currentfemalemodel = null;
                GeneralStaticdata.currentmalemodel = null;
            }
          if ((femalemodelitem.Any(a => a.Username == loginmodel.UserName)) && (femalemodelitem.Any(a => a.Password == loginmodel.Password)))
          {
                navmanager.NavigateTo("/modelmainpage");
                GeneralStaticdata.loggedin = true;
                //GenericStaticdata<FemaleModelModel>.loggedinmodel = femalemodelitem.Where(a => a.Username == loginmodel.UserName).FirstOrDefault();
                GeneralStaticdata.currentadminmodel = null;
                GeneralStaticdata.currentclientmodel = null;
                GeneralStaticdata.currentfemalemodel = femalemodelitem.Where(a => a.Username == loginmodel.UserName).FirstOrDefault();
                GeneralStaticdata.currentmalemodel = null;
            }
            if ((malemodelitem.Any(a => a.Username == loginmodel.UserName)) && (malemodelitem.Any(a => a.Password == loginmodel.Password)))
            {
                navmanager.NavigateTo("/modelmainpage");
                GeneralStaticdata.loggedin = true;
                //GenericStaticdata<MaleModeModel>.loggedinmodel = malemodelitem.Where(a => a.Username == loginmodel.UserName).FirstOrDefault();
                GeneralStaticdata.currentadminmodel = null;
                GeneralStaticdata.currentclientmodel = null;
                GeneralStaticdata.currentfemalemodel = null ;
                GeneralStaticdata.currentmalemodel = malemodelitem.Where(a => a.Username == loginmodel.UserName).FirstOrDefault(); ;
            }
          
        }

        public void test()
        {
            MaleModeModel model = new MaleModeModel();
            Console.WriteLine("something");
        }

    }
}
