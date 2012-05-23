using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace webBrowserIE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //changes the hover image and pressed image of buttons in addressbar
        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            this.backButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.back_prelight));
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            this.backButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.back));
        }

        private void backButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.backButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.back_pressed));
        }

        private void backButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.backButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.back_prelight));
        }

        private void forwardButton_MouseEnter(object sender, EventArgs e)
        {
            this.forwardButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.forward_prelight));
        }

        private void forwardButton_MouseLeave(object sender, EventArgs e)
        {
            this.forwardButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.forward));
        }

        private void forwardButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.forwardButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.forward_pressed));
        }

        private void forwardButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.forwardButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.forward_prelight));
        }

        private void refreshButton_MouseEnter(object sender, EventArgs e)
        {
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.reload_prelight));
        }

        private void refreshButton_MouseLeave(object sender, EventArgs e)
        {
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.reload));
        }

        private void refreshButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.reload_pressed));
        }

        private void refreshButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.reload_prelight));
        }       

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cancel_prelight));
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cancel));
        }

        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cancel_pressed));
        }

        private void cancelButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cancel_prelight));
        }

        private void goButton_MouseEnter(object sender, EventArgs e)
        {
            this.goButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.go_prelight));
        }

        private void goButton_MouseLeave(object sender, EventArgs e)
        {
            this.goButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.go));
        }

        private void goButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.goButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.go_pressed));
        }

        private void goButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.goButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.go_prelight));
        }

        private void historyButton_MouseEnter(object sender, EventArgs e)
        {
            this.historyButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.history_prelight));
        }

        private void historyButton_MouseLeave(object sender, EventArgs e)
        {
            this.historyButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.history));
        }

        private void historyButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.historyButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.history_pressed));
        }

        private void historyButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.historyButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.history_prelight));
        }

        private void aboutButton_MouseEnter(object sender, EventArgs e)
        {
            this.aboutButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_prelight));
        }

        private void aboutButton_MouseLeave(object sender, EventArgs e)
        {
            this.aboutButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about));
        }

        private void aboutButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.aboutButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_pressed));
        }

        private void aboutButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.aboutButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_prelight));
        }
        //---------------------------------------------------------------------------------------------------

        //hide history panel, progressbar at the begening and loads homepage
        private void Form1_Load(object sender, EventArgs e)
        {
            historyPanel.Visible = false;
            progressBar.Visible = false;
            webBrowser.Navigate(textBoxAddressBar.Text.ToString());
        }
        //method for back button
        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }
        //method for history toggel button
        private void historyButton_Click(object sender, EventArgs e)
        {
            if (historyPanel.Visible.Equals(false))
            {
                historyPanel.Visible = true;
            }
            else
                historyPanel.Visible = false;
        }
        //method for go button
        private void goButton_Click(object sender, EventArgs e)
        {
            string url = textBoxAddressBar.Text;

            if (!String.IsNullOrEmpty(url))
            {
                webBrowser.Navigate(url);
            }
        }
        //method for forward button
        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }
        //method for refresh button
        private void refreshButton_Click(object sender, EventArgs e)
        {
            string currenturl = textBoxAddressBar.Text.ToString();
            webBrowser.Navigate(currenturl);
        }
        //method for close button in history panel
        private void closeButton_Click(object sender, EventArgs e)
        {
            historyPanel.Visible = false;
        }
        //method to navigate to the web page selected from history combo box
        private void comboBoxHistoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string historyurl = comboBoxHistoryList.SelectedItem.ToString();
            webBrowser.Navigate(historyurl);
        }
        //method for cancel button
        private void cancelButton_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }
        //web browser nagivating method
        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            progressBar.Visible = true;
            cancelButton.Enabled = true;
            labelDone.Visible = false;
            labelOpen.Visible = true;            
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            labelOpen.Text = "Loading : " + webBrowser.Url.ToString();  //display the url of loading page
            textBoxAddressBar.Text = webBrowser.Url.ToString();         //change the text of address bar
            //change the tittle of the window to the tittle of the web page
            Form1.ActiveForm.Text = webBrowser.DocumentTitle.ToString() + " - Internet Navigator";           
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            comboBoxHistoryList.Items.Add(webBrowser.Url.ToString()); //add web page to history list
            progressBar.Visible = false;
            labelOpen.Visible = false;
            labelDone.Visible = true;
            cancelButton.Enabled = false;            
        }
        //method to navigate to a web page when enter is pressed in address bar
        private void textBoxAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = textBoxAddressBar.Text.ToString();
                if (!String.IsNullOrEmpty(url))
                {
                    webBrowser.Navigate(url);
                }
            }
        }
        //method for about button
        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form3 aboutform = new Form3();
            aboutform.Show();
        }
        //method which sets progrssbar values
        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar.Maximum = Convert.ToInt32(e.MaximumProgress);
            progressBar.Value = Convert.ToInt32(e.CurrentProgress);
        }
    }
}
