using ProductModel;
using System;
using System.Globalization;
using System.Threading;

namespace ProductConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo Cirl = new CultureInfo("ie-IE");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ProductDBContext.inProduction = true;
            using (ProductDBContext db = new ProductDBContext())
            {
                foreach (Product product in db.Products)
                    Console.WriteLine("{0} Costs {1:C} ", product.Description,  product.UnitPrice);
            }
        }
    }
}
