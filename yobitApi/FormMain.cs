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
        private readonly RestClient client = new RestClient();

        private readonly JsonDeserialize jsonDeserialize = new JsonDeserialize();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        { 
            client.EndPoint = "https://yobit.net/api/3/info";

            string strResponse = client.MakeRequest();

            foreach (var item in jsonDeserialize.DeserializeInfo(strResponse))
            {
                listBoxPair.Items.Add(item);
            }
           

        }

        private void listBoxPair_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSelectedPair.Text = listBoxPair.SelectedItem.ToString();
        }

        private void textBoxSearchPair_TextChanged(object sender, EventArgs e)
        {
            listBoxPair.Items.Clear();
            client.EndPoint = "https://yobit.net/api/3/info";
            string strResponse = client.MakeRequest();

            foreach (var item in jsonDeserialize.DeserializeInfo(strResponse,textBoxSearchPair.Text))
            {
                listBoxPair.Items.Add(item);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
