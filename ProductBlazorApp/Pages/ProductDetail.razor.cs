﻿using Microsoft.AspNetCore.Components;
using ProductDataServices;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBlazorApp.Pages
{
    public partial class ProductDetail
    {
        
        [Parameter]
        public int ID { get; set; }
        public Product Product { get; set; }
        [Inject]    
        public IHttpClientService httpService { get; set; }

        public NavigationManager NavigationManager { get; set; }
        protected async override Task OnInitializedAsync()
        {
            try {
                if (await httpService.GetTokenAsync() != null)
                    Product = await httpService.getSingle<Product>(@"api\Products\GetProductWithSupplier\ProductId\", ID);
                else throw (new Exception("No Token Login found"));
                if (Product == null)
                {
                    throw (new Exception("No Product Found"));
                }
                else Console.WriteLine(Product.ID);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                NavigationManager.NavigateTo($"/Error/{e.Message}");

            }
        }
        

    }
}
