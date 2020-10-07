using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using yobitApiBl;

namespace yobitApiUi
{
    public partial class FormMain : Form
    {
        private readonly RestClient client = new RestClient();

        private readonly JsonDeserialize jsonDeserialize = new JsonDeserialize();

        private readonly string strResponsePair = "https://yobit.net/api/3/info";

        private readonly string strResponseTicker = "https://yobit.net/api/3/ticker/";



        private bool reloadTable = false;
        public FormMain()
        {
            InitializeComponent();
            comboBoxConvertPair.SelectedIndex = 0;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            client.EndPoint = strResponsePair;

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

            //reset settings stream api
            dataGridViewParser.Rows.Clear();
            reloadTable = false;
            buttonFind.BackColor = Color.Green;
            buttonFind.Text = "Start";
            textBoxLink.Text = "";


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
            client.EndPoint = strResponsePair;
            string strResponse = client.MakeRequest();

            foreach (var item in jsonDeserialize.DeserializeInfo(strResponse, textBoxSearchPair.Text))
            {
                listBoxPair.Items.Add(item);
            }
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {
            string _strResponseTicker = strResponseTicker;
            reloadTable = !reloadTable;
            if (reloadTable == false)
            {
                buttonFind.BackColor = Color.Green;
                buttonFind.Text = "Start";
            }
            else
            {
                buttonFind.BackColor = Color.Red;
                buttonFind.Text = "Stop";

                for (int row = 0; row < dataGridViewParser.Rows.Count - 1; row++)
                {
                    if (_strResponseTicker == strResponseTicker)
                    {
                        _strResponseTicker += (dataGridViewParser.Rows[row].Cells[0].Value.ToString());
                    }
                    else
                    {
                        _strResponseTicker += "-" + dataGridViewParser.Rows[row].Cells[0].Value.ToString();
                    }
                }
                textBoxLink.Text = _strResponseTicker;
            }
        }

        private void comboBoxConvertPair_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewParser.Columns[2].HeaderText ="Buy " + comboBoxConvertPair.SelectedItem.ToString();
            dataGridViewParser.Columns[3].HeaderText ="Sell " + comboBoxConvertPair.SelectedItem.ToString();
        }

        private void timerReloadParse_Tick(object sender, EventArgs e)
        {
  
            if (reloadTable == true)
            {
                if (!String.IsNullOrWhiteSpace(textBoxLink.Text))
                {

                    client.EndPoint = textBoxLink.Text;

                    int counter = 0;
                    string strResponse = client.MakeRequest();
                    foreach (KeyValuePair <string, CurrencyTicker>item in jsonDeserialize.DeserializeTicker(strResponse))
                    {  
                        dataGridViewParser.Rows[counter].Cells[1].Value = item.Value.Last;

                        counter++;
                    }
                }


            }
        }

        
}
}

