using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataServices
{
    public class Token
    {
        [JsonProperty("token")]
        public string AccessToken { get; set; }

        [JsonProperty("expiration")]
        public DateTime ExpiresIn { get; set; }

        
    }
}
