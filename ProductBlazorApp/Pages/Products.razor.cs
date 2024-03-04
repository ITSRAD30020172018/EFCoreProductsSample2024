using Microsoft.AspNetCore.Components;
using ProductDataServices;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBlazorApp.Pages
{
    public partial class Products
    {
        public List<Product> ProductsList { get; set; } = new List<Product>();
        [Inject]
        public IHttpClientService httpService { get; set; }
        //[Inject]
        //public ILocalStorageService localStorageService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                if (await httpService.GetTokenAsync() != null)
                    ProductsList = await httpService.getCollection<Product>(@"api\Products");
                else throw (new Exception("No Token Login found"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                NavigationManager.NavigateTo($"/Error/{e.Message}");

            }
        }

        
    }
}
