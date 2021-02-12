using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion2.Pages
{
    public partial class ClientMainPage
    {
        [Inject]
        public NavigationManager navmanager { get; set; }

        public void GoToAddData()
        {
            navmanager.NavigateTo("/clientadddata");
        }

        public void GoToAddEvent()
        {
            navmanager.NavigateTo("/clientaddevent");
        }

        public void GoToModelsOverview()
        {
            navmanager.NavigateTo("/clientmodelsoverview");
        }
    }
}
