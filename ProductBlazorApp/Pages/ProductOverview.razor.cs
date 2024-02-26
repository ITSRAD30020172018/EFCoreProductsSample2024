using ProductModel;

namespace ProductBlazorApp.Pages
{
    public partial class ProductOverview
    {
        IEnumerable<Product> products;
        protected override Task OnInitializedAsync()
        {
            InitialiseProducts();
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
