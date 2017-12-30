using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS_API
{
    class AcceptOrderResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("newbalance")]
        public float NewBalance { get; set; }
    }
}
