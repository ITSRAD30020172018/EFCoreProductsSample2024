using Microsoft.AspNetCore.Components;
using ProductModel;

namespace ProductBlazorApp.Pages
{
    public partial class ProductDetail
    {
        IEnumerable<Product> products;
        [Parameter]
        public int ID { get; set; }
        public Product Product { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitialiseProducts();
            Product = products.FirstOrDefault(p => p.ID == ID);
            return base.OnInitializedAsync();
        }

        private void InitialiseProducts()
        {
            products = new List<Product>
            {
                new Product{ ID = 1, Description = "Chai", StockOnHand = 12},
                new Product{ ID = 2, Description = "Syrup", StockOnHand = 10},
                new Product{ ID = 3, Description = "Cajun Seasoning", StockOnHand = 200},
            };
        }
    }
}
