using Data.Models;
using Logic.StaticResources;
using Microsoft.AspNetCore.Components;
using ModellenBureauBlazorVersion3.Client.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion2.Pages
{
    public partial class ClientAddEvent
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

        public EventModel tobeaddedevent { get; set; }

        [Inject]
        public NavigationManager navmanager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            tobeaddedevent = new EventModel();

        }

        public async void AddEvent()
        {
            await _eventDataService.AddEvent(tobeaddedevent);
            navmanager.NavigateTo("/clientmainpage");
        }
    }
}
