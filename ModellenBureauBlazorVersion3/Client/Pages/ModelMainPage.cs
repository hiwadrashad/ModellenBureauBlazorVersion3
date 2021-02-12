using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion2.Pages
{
    public partial class ModelMainPage
    {
        [Inject]
        public NavigationManager navmanager { get; set; }

        public void GoToAddData()
        {
            navmanager.NavigateTo("/modeladddata");
        }

        public void GoToEvents()
        {
            navmanager.NavigateTo("/modeleventsoverview");
        }

    }
}
