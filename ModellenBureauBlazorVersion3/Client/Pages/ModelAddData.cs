using Data.Models;
using Logic.StaticResources;
using Microsoft.AspNetCore.Components;
using ModellenBureauBlazorVersion3.Client.DataServices;
using System.Threading.Tasks;


namespace ModellenBureauBlazorVersion2.Pages
{
    public partial class ModelAddData
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
        
        public MaleModeModel loginmalemodel { get; set; }
        public FemaleModelModel loginfemalemodel { get; set; }

        [Inject]
        public NavigationManager navmanager { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    if (GeneralStaticdata.currentfemalemodel != null)
        //    {
        //        loginfemalemodel = GeneralStaticdata.currentfemalemodel;

        //    }
        //    else
        //    {
        //        if (GeneralStaticdata.currentmalemodel != null)
        //        {
        //            loginmalemodel = GeneralStaticdata.currentmalemodel;
        //        }
        //        else
        //        {
        //            loginmalemodel = new MaleModeModel();
        //        }
        //    }
        //}

        public async void EditMaleModel()
        {
            await _maleModelDataService.UpdateMaleModel(loginmalemodel);
            navmanager.NavigateTo("/modelmainpage");
        }

        public async void EditFemaleModel()
        {
            await _femaleModelDataService.UpdateFemaleModel(loginfemalemodel);
            navmanager.NavigateTo("/modelmainpage");
        }
    }
}
