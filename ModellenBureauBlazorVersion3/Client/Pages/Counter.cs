using Microsoft.AspNetCore.Components;
using ModellenBureauBlazorVersion3.Client.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion3.Client.Pages
{
    
    public partial class Counter
    {
        [Inject]
        public IAdminDataService _dataService { get; set; }
        public List<string> TestStrings { get; set; }
        protected override async Task OnInitializedAsync()
        {
            TestStrings = (await _dataService.GetAllAdmins()).ToList();
        }

        public async void Clicked()
        {
            TestStrings = (await _dataService.GetAllAdmins()).ToList();
            StateHasChanged();
        }
    }
}
