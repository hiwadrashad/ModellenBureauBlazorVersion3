using Data.Models;
using Microsoft.AspNetCore.Components;
using ModellenBureauBlazorVersion3.Client.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion2.Pages
{
    public partial class ClientModelsOverview
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
        public List<MaleModeModel> MaleModels { get; set; }
        public List<FemaleModelModel> FemaleModels { get; set; }
        [Inject]
        public NavigationManager navmanager { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    MaleModels = (await _maleModelDataService.GetAllMaleModels()).ToList();
        //    FemaleModels = (await _femaleModelDataService.GetAllFemaleModels()).ToList();

        //}
    }
}
