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
    public partial class ModeInvitedEvent
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

        //public MaleModeModel loginmalemodel { get; set; }
        //public FemaleModelModel loginfemalemodel { get; set; }
        //public List<EventModel> Events { get; set; }

        //[Inject]
        //public NavigationManager navmanager { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    if (GeneralStaticdata.currentfemalemodel != null)
        //    {                 
        //        Events = (await _eventDataService.GetAllEvents()).Where(a => a.FemaleModels.Contains(GeneralStaticdata.currentfemalemodel)).ToList();
        //    }
        //    else
        //    {
        //        Events = (await _eventDataService.GetAllEvents()).Where(a => a.MaleModels.Contains(GeneralStaticdata.currentmalemodel)).ToList();
        //    }
        //}
    }
}
