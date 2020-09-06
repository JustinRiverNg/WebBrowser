﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsMainForm
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
