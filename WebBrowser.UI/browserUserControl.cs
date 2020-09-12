using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /** Change the url in the address field if the user clicks to navigate to a new page. */
        private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            addressTextBox.Text = webBrowser1.Url.ToString();
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
    }
}
