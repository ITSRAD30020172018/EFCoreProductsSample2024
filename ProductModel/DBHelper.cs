using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public static class DBHelper
    {
        public static List<T> Get<T>(string resourceName)
        {
            {   
                using (StreamReader reader = new StreamReader(resourceName, Encoding.UTF8))
                {
                    CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
                    csvReader.Context.RegisterClassMap<Map>();
                    return csvReader.GetRecords<T>().ToList();
                }
            }
        }

        
    }
}
