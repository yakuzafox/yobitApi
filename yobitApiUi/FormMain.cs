using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using yobitApiBl;

namespace yobitApiUi
{
    public partial class FormMain : Form
    {
        private readonly RestClient client = new RestClient();

        private readonly JsonDeserialize jsonDeserialize = new JsonDeserialize();
        public FormMain()
        {
            InitializeComponent();
            comboBoxConvertPair.SelectedIndex = 0;
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
            string selectedCurrency = labelSelectedPair.Text;
            selectedCurrency = selectedCurrency.Substring(0, selectedCurrency.LastIndexOf('_') + 1);
            Regex regex = new Regex($@"^{selectedCurrency}", RegexOptions.IgnoreCase);
            dataGridViewParser.Rows.Clear();

            foreach (var key in listBoxPair.Items)
            {
                if (regex.IsMatch(key.ToString()))
                {
                    /* string str = key.Key.ToString();
                     str = str.Remove(str.IndexOf('_'), str.Length - str.IndexOf('_'));*/
                    dataGridViewParser.Rows.Add(key.ToString());
                }
            }

            
            
        }

        private void textBoxSearchPair_TextChanged(object sender, EventArgs e)
        {
            listBoxPair.Items.Clear();
            client.EndPoint = "https://yobit.net/api/3/info";
            string strResponse = client.MakeRequest();

            foreach (var item in jsonDeserialize.DeserializeInfo(strResponse, textBoxSearchPair.Text))
            {
                listBoxPair.Items.Add(item);
            }
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxConvertPair_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewParser.Columns[2].HeaderText ="Buy " + comboBoxConvertPair.SelectedItem.ToString();
            dataGridViewParser.Columns[3].HeaderText ="Sell " + comboBoxConvertPair.SelectedItem.ToString();
        }
    }
}

