using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace solarCell
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            labelProductName.Text += ": Temperature Measurement Measurement Modeling";
            labelVersion.Text += ": v0.1";
            labelCopyright.Text += ": © zsomoTech";
            labelCodedby.Text += ": Zsolt Molnár";
            linkLabelLink.Text = "https://sites.google.com/view/zsomotech/home";
        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sites.google.com/view/zsomotech/home");
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {

        }
    }
}
