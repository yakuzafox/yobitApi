﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace yobitApiBl
{
    public class JsonDeserialize
    {
        public List<string> DeserializeInfo (string url)
        {
            List<string> pairsList = new List<string>();
            try
            {
                var currencyInfo = JsonConvert.DeserializeObject<CurrencyInfo>(url);
                foreach (var key in currencyInfo.Pairs)
                { 
                    /*string str = key.Key.ToString();
                    str = str.Remove(str.IndexOf('_'), str.Length - str.IndexOf('_'));*/
                    pairsList.Add(key.Key.ToString());
                }
            }
            catch
            {
                pairsList.Add("Error");
            }
            return pairsList;
        }

        public List<string> DeserializeInfo(string url, string find)
        {
            Regex regex = new Regex($@"^{find}", RegexOptions.IgnoreCase);
            List<string> pairsList = new List<string>();
            try
            {
                var currencyInfo = JsonConvert.DeserializeObject<CurrencyInfo>(url);
                foreach (var key in currencyInfo.Pairs)
                {
                    if (regex.IsMatch(key.Key.ToString()))
                    {
                       /* string str = key.Key.ToString();
                        str = str.Remove(str.IndexOf('_'), str.Length - str.IndexOf('_'));*/
                        pairsList.Add(key.Key.ToString());
                    }
                }
            }
            catch
            {
                pairsList.Add("Error");
            }
            return pairsList;
        }

        public Dictionary<string, CurrencyTicker> DeserializeTicker(string url)
        {
            Dictionary<string, CurrencyTicker> tickerList = new Dictionary<string, CurrencyTicker>();
            try
            {
                tickerList = JsonConvert.DeserializeObject<Dictionary<string, CurrencyTicker>>(url);       
            }
            catch
            {
                throw new ArgumentException("error list currency ticker");
            }
            return tickerList;
        }



    }
}
