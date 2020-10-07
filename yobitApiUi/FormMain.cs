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

        //private readonly string strResponseBinBookTicker = "https://www.binance.com/api/v3/ticker/bookTicker";

        private readonly string strResponseBinExchangeInfo = "https://www.binance.com/api/v3/exchangeInfo";


        private bool reloadTable = false;
        public FormMain()
        {
            InitializeComponent();
            comboBoxConvertPair.SelectedIndex = 0;
            comboBoxExchange.SelectedIndex = 0;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            switch(comboBoxExchange.Text)
            {
                case "Yobit":
                    client.EndPoint = strResponsePair;
                    string strResponse = client.MakeRequest();
                    Yobit.ListBoxFiller(jsonDeserialize, strResponse, listBoxPair, textBoxLog);
                break;
                case "Binance":
                    client.EndPoint = strResponseBinExchangeInfo;
                    strResponse = client.MakeRequest();
                    Binance.ListBoxFiller(jsonDeserialize, strResponse, listBoxPair, textBoxLog);
                break;
            }
            
        }

        private void listBoxPair_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset settings stream api
            dataGridViewParser.Rows.Clear();
            reloadTable = false;
            buttonFind.BackColor = Color.Green;
            buttonFind.Text = "Start";
            textBoxLink.Text = "";

            switch (comboBoxExchange.Text)
            {
                case "Yobit":
                    Yobit.DataGridViewFiller(listBoxPair, labelSelectedPair, dataGridViewParser);
                break;
            }
            
        }

        private void textBoxSearchPair_TextChanged(object sender, EventArgs e)
        {
            listBoxPair.Items.Clear();
            
            switch (comboBoxExchange.Text)
            {
                case "Yobit":
                    client.EndPoint = strResponsePair;
                    string strResponse = client.MakeRequest();
                    Yobit.ListBoxFiller(jsonDeserialize, strResponse, listBoxPair, textBoxLog, textBoxSearchPair);
                break;
                case "Binance":
                    client.EndPoint = strResponseBinExchangeInfo;
                    strResponse = client.MakeRequest();
                    Binance.ListBoxFiller(jsonDeserialize, strResponse, listBoxPair, textBoxLog, textBoxSearchPair.Text);
                break;


            }
            
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {
            string _strResponseTicker = strResponseTicker;
            reloadTable = !reloadTable;
            switch (comboBoxExchange.Text)
            {
                case "Yobit":
                    Yobit.StreamDataGrid(reloadTable, buttonFind, dataGridViewParser, textBoxLink, _strResponseTicker, strResponseTicker);
                    break;

            }
            
            
        }

        private void comboBoxConvertPair_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewParser.Columns[3].HeaderText ="Buy " + comboBoxConvertPair.SelectedItem.ToString();
            dataGridViewParser.Columns[4].HeaderText ="Sell " + comboBoxConvertPair.SelectedItem.ToString();
        }

        private void timerReloadParse_Tick(object sender, EventArgs e)
        {
            switch (comboBoxExchange.Text)
            {
                case "Yobit":
                    Yobit.StreamDataGrid(reloadTable, dataGridViewParser, textBoxLog, textBoxLink, client, jsonDeserialize);
                    break;

            }
            
        }

        private void comboBoxExchange_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewParser.Rows.Clear();
            reloadTable = false;
            buttonFind.BackColor = Color.Green;
            buttonFind.Text = "Start";
            textBoxLink.Clear();
            textBoxSearchPair.Clear();
            listBoxPair.Items.Clear();


            
            switch (comboBoxExchange.Text)
            {
                case "Yobit":
                    client.EndPoint = strResponsePair;
                    string strResponse = client.MakeRequest();
                    Yobit.ListBoxFiller(jsonDeserialize, strResponse, listBoxPair, textBoxLog);
                break;
                case "Binance":
                    client.EndPoint = strResponseBinExchangeInfo;
                    strResponse = client.MakeRequest();
                    Binance.ListBoxFiller(jsonDeserialize, strResponse, listBoxPair, textBoxLog);
                break;
            }
        }
    }
}

