using Microsoft.AspNetCore.Components;
using ProductDataServices;
using ProductModel;

namespace ProductBlazorApp.Pages
{
    public partial class SupplierProduct
    {
        [Inject]
        public IHttpClientService httpService { get; set; }
        [Inject]
        public ILocalStorageService localStorageService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public List<Supplier>? supplierList { get; set; } = new List<Supplier>();

        public Supplier? CurrentSupplier { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                if (await httpService.GetTokenAsync() != null)
                {
                    supplierList = await httpService.getCollection<Supplier>(@"api\Products\GetSupplierList");
                    CurrentSupplier = supplierList.FirstOrDefault();
                }
                else throw (new Exception("No Token Login found"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                NavigationManager.NavigateTo($"/Error/{e.Message}");

            }
        }
        private Task FilterSupplier(int chosen)
        {
            CurrentSupplier = supplierList.FirstOrDefault(s => s.SupplierID == chosen);
            return null;

        }
    }
}
