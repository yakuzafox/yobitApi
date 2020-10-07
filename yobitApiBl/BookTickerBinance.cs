using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace yobitApiBl
{
    public class BookTickerBinance
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("bidPrice")]
        public string BidPrice { get; set; }

        [JsonProperty("bidQty")]
        public string BidQty { get; set; }

        [JsonProperty("askPrice")]
        public string AskPrice { get; set; }

        [JsonProperty("askQty")]
        public string AskQty { get; set; }
    }
}
