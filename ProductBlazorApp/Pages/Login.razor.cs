using BlazorToastNotifications.Services;
using Microsoft.AspNetCore.Components;
using ProductDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBlazorApp.Pages
{
    public partial class Login
    {
        [Inject]
        public IHttpClientService httpService { get; set; }
        [Inject]
        AppState appState { get; set; }

        Token token = null;
        [Inject]
        ToastService toastService { get; set; }

        ViewModels.LoginViewModel model = new ViewModels.LoginViewModel();
        private bool loading;

        protected async override Task OnInitializedAsync()
        {
            token = await httpService.GetTokenAsync();
            if (token != null)
            {
                appState.LoggedIn = true;
                NavigationManager.NavigateTo("/");
            }
        }
        private async void OnValidSubmit()
        {
            loading = true;
            try
            {
                
              if (await httpService.login(model.Username, model.Password))
                {
                    appState.LoggedIn = true;
                    NavigationManager.NavigateTo("/");
                    toastService.ShowToast($"Successfully logged in", ToastLevel.Success);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                loading = false;
                StateHasChanged();
                toastService.ShowToast($"Unsuccessful login", ToastLevel.Success);
            }
        }
    }
}
