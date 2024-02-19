using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public class Map : ClassMap<Product>  
    {
        public Map()
        {
            //Map(m => m.ID).Name("ID");
            Map(m => m.Description).Name("Description");
            Map(m => m.ReorderLevel).Name("ReorderLevel");
            Map(m => m.ReorderQuantity).Name("ReorderQuantity");
            Map(m => m.StockOnHand).Name("StockOnHand");
            Map(m => m.UnitPrice).Name("UnitPrice");
        }
    }
}
