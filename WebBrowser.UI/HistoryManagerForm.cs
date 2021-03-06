﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.getItems();
            historyListBox.Items.Clear();

            foreach(var item in items)
            {
                historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date.ToString(), item.Title, item.URL));
            }
        }

        private void HistorySearchButton_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.getItems();
            historyListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.Title.Contains(searchTextBox.Text) || (item.URL.Contains(searchTextBox.Text))) {
                    historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryManager.clearItems();
            historyListBox.Items.Clear();
        }

        private void DeleteHistoryButton_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.getItems();
            string historyItemString = historyListBox.SelectedItem.ToString();
            string historyURL = historyItemString.Substring(historyItemString.IndexOf('(') + 1, historyItemString.IndexOf(')') -
                (historyItemString.IndexOf('(') + 1));
            items = HistoryManager.deleteItem(historyURL);
            historyListBox.Items.Clear();

            foreach (var item in items)
            {
                historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }
    }
}
