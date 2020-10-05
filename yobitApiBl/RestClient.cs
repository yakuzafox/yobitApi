using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Http;

namespace yobitApiBl
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    public class RestClient
    {
        public string EndPoint { get; set; }
        public HttpVerb HttpMethod { get; set; }

        public RestClient()
        {
            EndPoint = string.Empty;
            HttpMethod = HttpVerb.GET;
        }

        public string MakeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EndPoint);
            request.Method = HttpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode);
                }
                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {  
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }//end of streamReader
                    }

                }// end of using responseStream


            }// end of using response


            return strResponseValue;
        }

    }
}
