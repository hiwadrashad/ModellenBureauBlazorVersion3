using Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureauBlazorVersion2.Pages
{
    public partial class AdminMainPage
    {

        [Inject]
        public NavigationManager navmanager { get; set; }

        public void GoToNotAcceptedAccounts()
        {
            navmanager.NavigateTo("/adminoverviewtonotacceptedaccounts");
        }

        public void GoToAcceptedAccounts()
        {
            navmanager.NavigateTo("/adminoverviewacceptedaccounts");
        }
    }
}
