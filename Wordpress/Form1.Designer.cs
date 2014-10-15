namespace Wordpress
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
            this.btnGet = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.rtResponse = new System.Windows.Forms.RichTextBox();
            this.btnCompleteAuth = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.browser1 = new System.Windows.Forms.WebBrowser();
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRedirectUri = new System.Windows.Forms.TextBox();
            this.tbClientSecret = new System.Windows.Forms.TextBox();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAuth = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGet.Location = new System.Drawing.Point(13, 614);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "button1";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpMain);
            this.tabControl.Controls.Add(this.tpAuth);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(872, 595);
            this.tabControl.TabIndex = 1;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.rtResponse);
            this.tpMain.Controls.Add(this.btnCompleteAuth);
            this.tpMain.Controls.Add(this.btnDone);
            this.tpMain.Controls.Add(this.browser1);
            this.tpMain.Controls.Add(this.btnAuthorize);
            this.tpMain.Controls.Add(this.groupBox1);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(864, 569);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // rtResponse
            // 
            this.rtResponse.Location = new System.Drawing.Point(578, 148);
            this.rtResponse.Name = "rtResponse";
            this.rtResponse.ReadOnly = true;
            this.rtResponse.Size = new System.Drawing.Size(267, 402);
            this.rtResponse.TabIndex = 5;
            this.rtResponse.Text = "";
            // 
            // btnCompleteAuth
            // 
            this.btnCompleteAuth.Location = new System.Drawing.Point(578, 83);
            this.btnCompleteAuth.Name = "btnCompleteAuth";
            this.btnCompleteAuth.Size = new System.Drawing.Size(75, 23);
            this.btnCompleteAuth.TabIndex = 4;
            this.btnCompleteAuth.Text = "Complete";
            this.btnCompleteAuth.UseVisualStyleBackColor = true;
            this.btnCompleteAuth.Click += new System.EventHandler(this.btnCompleteAuth_Click);
            // 
            // btnDone
            // 
            this.btnDone.Enabled = false;
            this.btnDone.Location = new System.Drawing.Point(578, 50);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Got It";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // browser1
            // 
            this.browser1.Location = new System.Drawing.Point(7, 148);
            this.browser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser1.Name = "browser1";
            this.browser1.ScriptErrorsSuppressed = true;
            this.browser1.Size = new System.Drawing.Size(545, 415);
            this.browser1.TabIndex = 2;
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.Location = new System.Drawing.Point(578, 17);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorize.TabIndex = 1;
            this.btnAuthorize.Text = "Authorize";
            this.btnAuthorize.UseVisualStyleBackColor = true;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbRedirectUri);
            this.groupBox1.Controls.Add(this.tbClientSecret);
            this.groupBox1.Controls.Add(this.tbClientID);
            this.groupBox1.Controls.Add(this.tbClientName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "App Info";
            // 
            // tbCode
            // 
            this.tbCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCode.Location = new System.Drawing.Point(95, 102);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(444, 20);
            this.tbCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Code";
            // 
            // tbRedirectUri
            // 
            this.tbRedirectUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRedirectUri.Location = new System.Drawing.Point(95, 80);
            this.tbRedirectUri.Name = "tbRedirectUri";
            this.tbRedirectUri.Size = new System.Drawing.Size(444, 20);
            this.tbRedirectUri.TabIndex = 7;
            this.tbRedirectUri.Text = "http://project365.thepotters.org";
            // 
            // tbClientSecret
            // 
            this.tbClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientSecret.Location = new System.Drawing.Point(95, 59);
            this.tbClientSecret.Name = "tbClientSecret";
            this.tbClientSecret.Size = new System.Drawing.Size(444, 20);
            this.tbClientSecret.TabIndex = 6;
            this.tbClientSecret.Text = "T9G9QgHVgmdrDgbP3ruTJvrMAcIid8Z1DmvJyXpYAokJRXBZ1oz78QeKMZhCaCpI";
            // 
            // tbClientID
            // 
            this.tbClientID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientID.Location = new System.Drawing.Point(95, 38);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(444, 20);
            this.tbClientID.TabIndex = 5;
            this.tbClientID.Text = "37262";
            // 
            // tbClientName
            // 
            this.tbClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientName.Location = new System.Drawing.Point(95, 17);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(444, 20);
            this.tbClientName.TabIndex = 4;
            this.tbClientName.Text = "FeaturedImageUpdater";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Redirect URL";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client Secret";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // tpAuth
            // 
            this.tpAuth.Location = new System.Drawing.Point(4, 22);
            this.tpAuth.Name = "tpAuth";
            this.tpAuth.Padding = new System.Windows.Forms.Padding(3);
            this.tpAuth.Size = new System.Drawing.Size(864, 569);
            this.tpAuth.TabIndex = 1;
            this.tpAuth.Text = "Authorization";
            this.tpAuth.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 649);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpAuth;
        private System.Windows.Forms.WebBrowser browser1;
        private System.Windows.Forms.Button btnAuthorize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRedirectUri;
        private System.Windows.Forms.TextBox tbClientSecret;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCompleteAuth;
        private System.Windows.Forms.RichTextBox rtResponse;
    }
}

