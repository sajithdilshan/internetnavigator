using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace webBrowserIE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_MouseEnter(object sender, EventArgs e)
        {
            this.okButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ok_prelight));
        }

        private void okButton_MouseLeave(object sender, EventArgs e)
        {
            this.okButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ok));
        }

        private void okButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.okButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ok_pressed));
        }

        private void okButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.okButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ok_prelight));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:sajithdilsha@gmail.com");
        }

        
    }
}
