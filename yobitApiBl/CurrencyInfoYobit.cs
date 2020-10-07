using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace yobitApiBl
{
    public class CurrencyInfoYobit
    {
        [JsonProperty("server_time")]
        public long ServerTime { get; set; }

        [JsonProperty("pairs")]
        public Dictionary<string, CurrencyPairYobit> Pairs { get; set; }
    }
}
