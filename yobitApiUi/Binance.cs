﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using yobitApiBl;

namespace yobitApiUi
{
    public class Binance
    {
        public static void ListBoxFiller(JsonDeserialize deserializer, string strResponse, ListBox listBox, TextBox textBoxLog)
        {
            try
            {
                foreach (var item in deserializer.DeserializePair(strResponse))
                {
                    listBox.Items.Add(item);
                }
            }
            catch
            {
                textBoxLog.Text += strResponse + Environment.NewLine;
            }
        }

        public static void ListBoxFiller(JsonDeserialize deserializer, string strResponse, ListBox listBox, TextBox textBoxLog, string find)
        {
            Regex regex = new Regex($@"^{find}", RegexOptions.IgnoreCase);
            try
            {
                foreach (var item in deserializer.DeserializePair(strResponse))
                {
                    if (regex.IsMatch(item))
                    {
                        listBox.Items.Add(item);
                    }
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
    }
}
