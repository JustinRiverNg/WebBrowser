using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! Thank you for using my web browser. This web browser was built as part of a project in my " +
                "Software Construction Fundamentals course at Auburn University. It is currently a work in progress with updates to come. " +
                "It has helped me hone my application development skills to eventually become a software engineer. " +
                "\nName: Justin Ng \nAuburn Univeristy Student ID: 904090369");
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
        }

        /** "Add Tab" functionality on-click. The new tab will include the browserUserControl that fills the dock.*/
        private void NewTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var page = new TabPage("New Tab");
            var tabContent = new browserUserControl();
            page.Controls.Add(tabContent);
            tabContent.Dock = DockStyle.Fill; // Fill the new tab with the browserUserControl.
            this.tabControl1.TabPages.Add(page);
        }

        /** "Close Current Tab" functionality on-click. */
        private void CloseCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }
    }
}
