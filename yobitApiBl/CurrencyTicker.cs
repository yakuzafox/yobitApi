using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace yobitApiBl
{
    public class CurrencyTicker
    {
        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("avg")]
        public double Avg { get; set; }

        [JsonProperty("vol")]
        public double Vol { get; set; }

        [JsonProperty("vol_cur")]
        public double VolCur { get; set; }

        [JsonProperty("last")]
        public double Last { get; set; }

        [JsonProperty("buy")]
        public double Buy { get; set; }

        [JsonProperty("sell")]
        public double Sell { get; set; }

        [JsonProperty("updated")]
        public long Updated { get; set; }
    }
}
