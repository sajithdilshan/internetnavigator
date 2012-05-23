namespace webBrowserIE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel11 = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel10 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.comboBoxHistoryList = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxAddressBar = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.historyPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.webBrowser);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 70);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(789, 411);
            this.panel11.TabIndex = 3;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(789, 411);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            this.webBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Navigating);
            this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser_ProgressChanged);
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::webBrowserIE.Properties.Resources.statusbar;
            this.panel10.Controls.Add(this.progressBar);
            this.panel10.Controls.Add(this.labelOpen);
            this.panel10.Controls.Add(this.labelDone);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 481);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(789, 20);
            this.panel10.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.progressBar.Location = new System.Drawing.Point(669, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(120, 20);
            this.progressBar.TabIndex = 2;
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.BackColor = System.Drawing.Color.Transparent;
            this.labelOpen.Location = new System.Drawing.Point(2, 2);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(0, 13);
            this.labelOpen.TabIndex = 1;
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.BackColor = System.Drawing.Color.Transparent;
            this.labelDone.Location = new System.Drawing.Point(2, 2);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(33, 13);
            this.labelDone.TabIndex = 0;
            this.labelDone.Text = "Done";
            // 
            // historyPanel
            // 
            this.historyPanel.BackgroundImage = global::webBrowserIE.Properties.Resources.historybar;
            this.historyPanel.Controls.Add(this.comboBoxHistoryList);
            this.historyPanel.Controls.Add(this.panel9);
            this.historyPanel.Controls.Add(this.panel8);
            this.historyPanel.Controls.Add(this.panel7);
            this.historyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyPanel.Location = new System.Drawing.Point(0, 40);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(789, 30);
            this.historyPanel.TabIndex = 1;
            // 
            // comboBoxHistoryList
            // 
            this.comboBoxHistoryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxHistoryList.FormattingEnabled = true;
            this.comboBoxHistoryList.Location = new System.Drawing.Point(59, 3);
            this.comboBoxHistoryList.Name = "comboBoxHistoryList";
            this.comboBoxHistoryList.Size = new System.Drawing.Size(691, 21);
            this.comboBoxHistoryList.TabIndex = 3;
            this.comboBoxHistoryList.Text = "http://www.google.com";
            this.comboBoxHistoryList.SelectedIndexChanged += new System.EventHandler(this.comboBoxHistoryList_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(59, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(691, 3);
            this.panel9.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.closeButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(750, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(39, 30);
            this.panel8.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::webBrowserIE.Properties.Resources.exit;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(5, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(59, 30);
            this.panel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "History : ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::webBrowserIE.Properties.Resources.addressbar;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(124, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 40);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxAddressBar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(569, 32);
            this.panel6.TabIndex = 1;
            // 
            // textBoxAddressBar
            // 
            this.textBoxAddressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxAddressBar.Location = new System.Drawing.Point(0, 12);
            this.textBoxAddressBar.Name = "textBoxAddressBar";
            this.textBoxAddressBar.Size = new System.Drawing.Size(569, 20);
            this.textBoxAddressBar.TabIndex = 0;
            this.textBoxAddressBar.Text = "http://www.google.com";
            this.textBoxAddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAddressBar_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(569, 8);
            this.panel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.aboutButton);
            this.panel2.Controls.Add(this.historyButton);
            this.panel2.Controls.Add(this.goButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(693, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 40);
            this.panel2.TabIndex = 1;
            // 
            // aboutButton
            // 
            this.aboutButton.BackgroundImage = global::webBrowserIE.Properties.Resources.about;
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Location = new System.Drawing.Point(65, 8);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(24, 24);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            this.aboutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aboutButton_MouseDown);
            this.aboutButton.MouseEnter += new System.EventHandler(this.aboutButton_MouseEnter);
            this.aboutButton.MouseLeave += new System.EventHandler(this.aboutButton_MouseLeave);
            this.aboutButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aboutButton_MouseUp);
            // 
            // historyButton
            // 
            this.historyButton.BackgroundImage = global::webBrowserIE.Properties.Resources.history;
            this.historyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.historyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Location = new System.Drawing.Point(35, 8);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(24, 24);
            this.historyButton.TabIndex = 1;
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            this.historyButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.historyButton_MouseDown);
            this.historyButton.MouseEnter += new System.EventHandler(this.historyButton_MouseEnter);
            this.historyButton.MouseLeave += new System.EventHandler(this.historyButton_MouseLeave);
            this.historyButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.historyButton_MouseUp);
            // 
            // goButton
            // 
            this.goButton.BackgroundImage = global::webBrowserIE.Properties.Resources.go;
            this.goButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Location = new System.Drawing.Point(5, 8);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(24, 24);
            this.goButton.TabIndex = 0;
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            this.goButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.goButton_MouseDown);
            this.goButton.MouseEnter += new System.EventHandler(this.goButton_MouseEnter);
            this.goButton.MouseLeave += new System.EventHandler(this.goButton_MouseLeave);
            this.goButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.goButton_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.cancelButton);
            this.panel3.Controls.Add(this.refreshButton);
            this.panel3.Controls.Add(this.forwardButton);
            this.panel3.Controls.Add(this.backButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 40);
            this.panel3.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::webBrowserIE.Properties.Resources.cancel;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(95, 8);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(24, 24);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            this.cancelButton.MouseEnter += new System.EventHandler(this.cancelButton_MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelButton_MouseLeave);
            this.cancelButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseUp);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::webBrowserIE.Properties.Resources.reload;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(65, 8);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(24, 24);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            this.refreshButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refreshButton_MouseDown);
            this.refreshButton.MouseEnter += new System.EventHandler(this.refreshButton_MouseEnter);
            this.refreshButton.MouseLeave += new System.EventHandler(this.refreshButton_MouseLeave);
            this.refreshButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.refreshButton_MouseUp);
            // 
            // forwardButton
            // 
            this.forwardButton.BackgroundImage = global::webBrowserIE.Properties.Resources.forward;
            this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forwardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.forwardButton.FlatAppearance.BorderSize = 0;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Location = new System.Drawing.Point(35, 8);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(24, 24);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            this.forwardButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forwardButton_MouseDown);
            this.forwardButton.MouseEnter += new System.EventHandler(this.forwardButton_MouseEnter);
            this.forwardButton.MouseLeave += new System.EventHandler(this.forwardButton_MouseLeave);
            this.forwardButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.forwardButton_MouseUp);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::webBrowserIE.Properties.Resources.back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(5, 8);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(24, 24);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseDown);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            this.backButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 501);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Navigator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.historyPanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxAddressBar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox comboBoxHistoryList;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

