using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yobitApiBl;


namespace yobitApi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RestClient client = new RestClient();
            client.EndPoint = "https://yobit.net/api/3/info";

            string strResponse = string.Empty;
            strResponse = client.MakeRequest();

            

            
            try
            {
                var currencyInfo = JsonConvert.DeserializeObject<CurrencyInfo>(strResponse);
                foreach(var key in currencyInfo.pairs)
                {
                    listBoxPair.Items.Add(key.Key.ToString());
                }
                // listBoxPair.Items.Add(currencyInfo.pairs.ElementAt(0).Key.ToString());

            }
            catch 
            {
                listBoxPair.Items.Add("Error");
            }
            

        }
    }
}
