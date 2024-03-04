using BlazorToastNotifications.Services;
using Microsoft.AspNetCore.Components;
using ProductDataServices;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBlazorApp.Pages
{
    public partial class EditProduct
    {
        [Parameter]
        public int ID { get; set; }
        public Product Product { get; set; }
        [Inject]
        public IHttpClientService httpService { get; set; }

        public string message { get; set; } = "Messages here";
        [Inject]
        public ToastService toastService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        List<Supplier> supplierList { get; set; } = new List<Supplier>();

        protected async override Task OnInitializedAsync()
        {
            try
            {
                if (await httpService.GetTokenAsync() != null)
                {
                    Product = await httpService.getSingle<Product>(@"api\Products\GetProductWithSupplier\ProductId\", ID);
                    supplierList = await httpService.getCollection<Supplier>(@"api\Products\GetSupplierList");
                }
                else throw (new Exception("No Token Login found"));
                if(supplierList == null || supplierList.Count() < 1 )
                    throw (new Exception("No Suppliers found on Product Edit Page"));
                if (Product == null)
                {
                    throw (new Exception("No Product Found for ID" + ID.ToString()));
                }
                else Console.WriteLine(Product.ID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                NavigationManager.NavigateTo($"/Error/{e.Message}");
            }
        }
        private void HandleValidSubmit()
        {
            if(Product.ID == 0)
            {
                httpService.Post(@"api\Products", Product);
                toastService.ShowToast($"New Product Saved", ToastLevel.Success);
            }
            else
            {
                httpService.Put(@"api\Products", Product);
                toastService.ShowToast($"Product Updated {Product.Description}", ToastLevel.Success);  
                
            }
            NavigationManager.NavigateTo("/products");
        }

        private void HandleInvalidSubmit()
        {

        }
    }
}
