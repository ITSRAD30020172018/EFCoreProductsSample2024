using BlazorToastNotifications.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProductDataServices;

namespace ProductBlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            // Customised Generic Http client Service
            builder.Services.AddHttpClient<IHttpClientService, HttpClientService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5001");
            });
            builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();
            builder.Services.AddSingleton<AppState>();
            builder.Services.AddScoped<ToastService>();
            //builder.Services.AddScoped<NavigationManager>();

            await builder.Build().RunAsync();
        }
    }
}
