using ProductAPIClientLibrary;
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
            CultureInfo Cirl = new CultureInfo("en-IE");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Try without authorisation and see what happens
            //using (ProductDBContext db = new ProductDBContext())
            //{
            //    foreach (Product product in db.Products)
            //        Console.WriteLine("{0} Costs {1:C} ", product.Description,  product.UnitPrice);
            //}
            if (ProductClient.login("paul@itsligo.ie", "P@ssw0rd!"))
            {
                Console.WriteLine($"Logged in Token is {ProductClient.UserToken}");
                Console.WriteLine("Trying Authenticated Queries");

                Product p = new
                    Product
                {
                    ID = 0,
                    Description = "Cornflakes",
                    UnitPrice = 2.0,
                    StockOnHand = 200
                };
                if (!ProductClient.PostProduct(p)) Console.WriteLine("Post was unsuccessful");
                else
                {
                    Console.WriteLine($"Product Added ");
                }

                foreach (Product product in ProductClient.getProducts())
                {
                    Console.WriteLine(" ID {0} Description {1} Costs {2} ", product.ID, product.Description, product.UnitPrice.ToString("C2",Cirl));
                }

            };
            Console.ReadKey();

        }
    }
}
