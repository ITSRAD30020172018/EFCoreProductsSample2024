using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public class MapSupplier : ClassMap<Supplier>  
    {
        public MapSupplier()
        {
            //Map(m => m.ID).Name("ID");
            Map(m => m.SupplierID).Name("SupplierID");
            Map(m => m.CompanyName).Name("CompanyNAme");
            Map(m => m.ContactName).Name("ContactName");
            Map(m => m.ContactTitle).Name("ContactTitle");
            Map(m => m.Address).Name("Address");
            Map(m => m.City).Name("City");
            Map(m => m.Region).Name("Region");
            Map(m => m.PostalCode).Name("PostalCode");
            Map(m => m.Country).Name("Country");
            Map(m => m.Phone).Name("Phone");


        }
    }
}
