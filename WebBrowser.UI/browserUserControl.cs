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

        Stack<string> backLinks = new Stack<string>();
        Stack<string> forwardLinks = new Stack<string>();

        public browserUserControl()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            String url = addressTextBox.Text;
            webBrowser1.Navigate(url);
        }

        private void AddressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String url = addressTextBox.Text;
                webBrowser1.Navigate(url);
            }
        }
    }
}
