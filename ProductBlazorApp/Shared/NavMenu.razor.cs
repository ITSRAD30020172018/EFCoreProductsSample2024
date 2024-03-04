using Microsoft.AspNetCore.Components;
using ProductDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBlazorApp.Shared
{
    public partial class NavMenu : IDisposable
    {
        
        [Inject]
        IHttpClientService httpService { get; set; }
        [Inject]
        AppState appState { get; set; }

        //public bool ShowLogin { get; set; } 
        protected override Task OnInitializedAsync()
        {
            appState.OnChange += StateHasChanged;

            //if (httpService.GetTokenAsync() != null)
            //{
            //    appState.LoggedIn = true;
            //}
            //else appState.LoggedIn = false;

            return base.OnInitializedAsync();
        }
        public void Dispose()
        {
            appState.OnChange -= StateHasChanged;
        }
    }
}
