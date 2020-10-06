using System;
using System.Collections.Generic;
using System.Text;

namespace yobitApiBl
{
    public class CurrencyInfo
    {
        public string server_time { get; set; }

        public Dictionary<string, CurrencyPair> pairs { get; set; }
    }
}
