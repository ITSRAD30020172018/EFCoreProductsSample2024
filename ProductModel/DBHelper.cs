using CsvHelper;
using CsvHelper.Configuration;
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

        public static List<T> Get<T, S>(string resourceName) where T : class where S : ClassMap<T>
        {
            // Get the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {   // create a stream reader
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                    { HasHeaderRecord = true,
                      MissingFieldFound = null
                    };
                    
                    // create a csv reader dor the stream
                    CsvReader csvReader = new CsvReader(reader, configuration);
                    

                    csvReader.Context.RegisterClassMap<S>();
                    return csvReader.GetRecords<T>().ToList();
                }
            }
        }
    }
}
