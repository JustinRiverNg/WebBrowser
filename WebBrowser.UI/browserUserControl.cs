using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class browserUserControl : UserControl
    {
        /** Fields. */
        Stack<string> backLinks = new Stack<string>();
        Stack<string> forwardLinks = new Stack<string>();

        public browserUserControl()
        {
            InitializeComponent();
        }

        /** Method for clicking the "go" button to navigate to a new page. */
        private void GoButton_Click(object sender, EventArgs e)
        {
            backLinks.Push(webBrowser1.Url.ToString());
            String url = addressTextBox.Text;
            webBrowser1.Navigate(url);
        }

        /** Method for clicking the "enter" button while in the addressTextBox to navigate to a new page. */
        private void AddressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                backLinks.Push(webBrowser1.Url.ToString());
                String url = addressTextBox.Text;
                webBrowser1.Navigate(url);
            }
        }

        /** Method for clicking the "refresh" button. */
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(webBrowser1.Url.ToString());
        }

        /** Method for clicking the "backButton" button. */
        private void BackLinksButton_Click(object sender, EventArgs e)
        {
            if (backLinks.Count != 0)
            {
                forwardLinks.Push(addressTextBox.Text);
                String url = backLinks.Pop();
                webBrowser1.Navigate(url);
            }
        }

        /** Method for clicking the "forwardLinks" button. */
        private void ForwardLinksButton_Click(object sender, EventArgs e)
        {
            if (forwardLinks.Count != 0)
            {
                backLinks.Push(addressTextBox.Text);
                String url = forwardLinks.Pop();
                webBrowser1.Navigate(url);
            }
            
        }



        /** Add the current url to the backLinks stack when the user clicks to navigate to a new page. This method occurs BEFORE the web browser has navigated. */
        private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }

        /** Change the url in the address field if the user navigates to a new page. This method occurs AFTER the web browser has navigated.*/
        private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            addressTextBox.Text = webBrowser1.Url.ToString();
            var item = new HistoryItem();
            item.URL = webBrowser1.Url.ToString();
            item.Title = webBrowser1.DocumentTitle;
            item.Date = DateTime.Now;

            HistoryManager.addItem(item);
        }

        private void BookmarkButton_Click(object sender, EventArgs e)
        {
            var newItem = new BookmarkItem();
            newItem.Title = webBrowser1.DocumentTitle;
            newItem.URL = webBrowser1.Url.ToString();

            Boolean bookmarkExistsAlready = false;
            var items = BookmarkManager.getItems();
            foreach(var item in items)
            {
                if (item.URL == newItem.URL)
                {
                    bookmarkExistsAlready = true;
                }
            }
            if (!bookmarkExistsAlready)
            {
                BookmarkManager.addItem(newItem);
            }
        }
    }
}
