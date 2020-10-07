using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using yobitApiBl;

namespace yobitApiUi
{
    public class Yobit
    {
        public static void ListBoxFiller(JsonDeserialize deserializer, string strResponse, ListBox listBox, TextBox textBoxLog)
        {
            try
            {
                foreach (var item in deserializer.DeserializeInfo(strResponse))
                {
                    listBox.Items.Add(item);
                }
            }
            catch
            {
                textBoxLog.Text += strResponse + Environment.NewLine;
            }
        }
        public static void ListBoxFiller(JsonDeserialize deserializer, string strResponse, ListBox listBox, TextBox textBoxLog, TextBox textBox)
        {
            try
            {
                foreach (var item in deserializer.DeserializeInfo(strResponse, textBox.Text))
                {
                    listBox.Items.Add(item);
                }
            }
            catch
            {
                textBoxLog.Text += strResponse + Environment.NewLine;
            }
        }
        public static void DataGridViewFiller(ListBox listBox, Label label, DataGridView dataGridView)
        {
            if (listBox.SelectedItem != null)
            {
                label.Text = listBox.SelectedItem.ToString();
            }
            string selectedCurrency = label.Text;
            selectedCurrency = selectedCurrency.Substring(0, selectedCurrency.LastIndexOf('_') + 1);
            Regex regex = new Regex($@"^{selectedCurrency}", RegexOptions.IgnoreCase);

            foreach (var key in listBox.Items)
            {
                if (regex.IsMatch(key.ToString()))
                {
                    dataGridView.Rows.Add(key.ToString());
                }
            }
        }
        public static void StreamDataGrid(bool reloadTable,Button buttonFind, DataGridView dataGridViewParser,TextBox textBoxLink,string _strResponseTicker, string strResponseTicker)
        {
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

        public static void StreamDataGrid(bool reloadTable, DataGridView dataGridViewParser, TextBox textBoxLog, TextBox textBoxLink,RestClient client, JsonDeserialize deserializer)
        {
            if (reloadTable == true)
            {
                if (!String.IsNullOrWhiteSpace(textBoxLink.Text))
                {
                    client.EndPoint = textBoxLink.Text;
                    int counter = 0;
                    string strResponse = client.MakeRequest();
                    try
                    {
                        foreach (KeyValuePair<string, CurrencyTickerYobit> item in deserializer.DeserializeTicker(strResponse))
                        {
                            dataGridViewParser.Rows[counter].Cells[1].Value = item.Value.Buy;
                            dataGridViewParser.Rows[counter].Cells[2].Value = item.Value.Sell;
                            counter++;
                        }
                    }
                    catch
                    {
                        textBoxLog.Text += strResponse + Environment.NewLine;
                    }
                }

            }
        }
    }
}
