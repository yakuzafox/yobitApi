using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace yobitApiBl
{
    public class CurrencyPair
    {
        [JsonProperty("decimal_places")]
        public long DecimalPlaces { get; set; }

        [JsonProperty("min_price")]
        public double MinPrice { get; set; }

        [JsonProperty("max_price")]
        public long MaxPrice { get; set; }

        [JsonProperty("min_amount")]
        public double MinAmount { get; set; }

        [JsonProperty("min_total")]
        public double MinTotal { get; set; }

        [JsonProperty("hidden")]
        public long Hidden { get; set; }

        [JsonProperty("fee")]
        public double Fee { get; set; }

        [JsonProperty("fee_buyer")]
        public double FeeBuyer { get; set; }

        [JsonProperty("fee_seller")]
        public double FeeSeller { get; set; }

    }
}
