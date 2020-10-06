using System;
using System.Collections.Generic;
using System.Text;

namespace yobitApiBl
{
    public class CurrencyPair
    {
        public double decimal_places { get; set; }
        public double min_price { get; set; }
        public double max_price { get; set; }
        public double min_amount { get; set; }
        public double min_total { get; set; }
        public double hidden { get; set; }
        public double fee { get; set; }
        public double fee_buyer { get; set; }
        public double fee_seller { get; set; }

    }
}
