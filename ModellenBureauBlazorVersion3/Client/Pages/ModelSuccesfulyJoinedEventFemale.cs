using Data.Models;
using Logic.StaticResources;
using Microsoft.AspNetCore.Components;
using ModellenBureauBlazorVersion3.Client.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.Pages
{
    public partial class ModelSuccesfulyJoinedEventFemale
    {
        //[Inject]
        //public IAdminDataService _adminDataService { get; set; }
        //[Inject]
        //public IClientDataService _clientDataService { get; set; }
        //[Inject]
        //public IEventDataService _eventDataService { get; set; }
        //[Inject]
        //public IFemaleModelDataService _femaleModelDataService { get; set; }
        //[Inject]
        //public IMaleModelDataService _maleModelDataService { get; set; }

        //[Inject]
        //public NavigationManager navmanager { get; set; }
        //[Parameter]
        //public string id { get; set; }

        //public void GoBack()
        //{
        //    navmanager.NavigateTo("/modelmainpage");
        //}

        //protected override async Task OnInitializedAsync()
        //{
        //    if (GeneralStaticdata.currentfemalemodel != null)
        //    {
        //        var item = await _eventDataService.GetAllEvents();
        //        var chosenevent = item.Where(a => a.id == id).FirstOrDefault();
        //        chosenevent.FemaleModels.Add(GeneralStaticdata.currentfemalemodel);
        //        await _eventDataService.UpdateEventsModel(chosenevent);
        //    }
        //    else 
        //    {
        //        navmanager.NavigateTo("/");
        //    }
        //}
    }
}
