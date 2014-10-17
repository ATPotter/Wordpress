namespace Wordpress.OAuthHandlers
{
    partial class FlickrOauth2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVerifier = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRequestTokenSecret = new System.Windows.Forms.Label();
            this.lblRequestToken = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbClientSecret = new System.Windows.Forms.TextBox();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRequestToken = new System.Windows.Forms.Button();
            this.btnUserAuthorisation = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.btnGetUrl = new System.Windows.Forms.Button();
            this.btnGetAccessToken = new System.Windows.Forms.Button();
            this.lblAuthToken = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNsId = new System.Windows.Forms.Label();
            this.lblAuthSecret = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNsId);
            this.groupBox1.Controls.Add(this.lblAuthSecret);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblAuthToken);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblVerifier);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblRequestTokenSecret);
            this.groupBox1.Controls.Add(this.lblRequestToken);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbClientSecret);
            this.groupBox1.Controls.Add(this.tbClientId);
            this.groupBox1.Controls.Add(this.tbClientName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblVerifier
            // 
            this.lblVerifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVerifier.Location = new System.Drawing.Point(76, 189);
            this.lblVerifier.Name = "lblVerifier";
            this.lblVerifier.Size = new System.Drawing.Size(274, 23);
            this.lblVerifier.TabIndex = 11;
            this.lblVerifier.Text = "---";
            this.lblVerifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Verifier";
            // 
            // lblRequestTokenSecret
            // 
            this.lblRequestTokenSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRequestTokenSecret.Location = new System.Drawing.Point(76, 144);
            this.lblRequestTokenSecret.Name = "lblRequestTokenSecret";
            this.lblRequestTokenSecret.Size = new System.Drawing.Size(274, 23);
            this.lblRequestTokenSecret.TabIndex = 9;
            this.lblRequestTokenSecret.Text = "---";
            this.lblRequestTokenSecret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRequestToken
            // 
            this.lblRequestToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRequestToken.Location = new System.Drawing.Point(76, 116);
            this.lblRequestToken.Name = "lblRequestToken";
            this.lblRequestToken.Size = new System.Drawing.Size(274, 23);
            this.lblRequestToken.TabIndex = 8;
            this.lblRequestToken.Text = "---";
            this.lblRequestToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Secret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Req. Token";
            // 
            // tbClientSecret
            // 
            this.tbClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientSecret.Location = new System.Drawing.Point(76, 82);
            this.tbClientSecret.Name = "tbClientSecret";
            this.tbClientSecret.Size = new System.Drawing.Size(274, 20);
            this.tbClientSecret.TabIndex = 5;
            this.tbClientSecret.Text = "a86534f2bcb31971";
            // 
            // tbClientId
            // 
            this.tbClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientId.Location = new System.Drawing.Point(76, 59);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(274, 20);
            this.tbClientId.TabIndex = 4;
            this.tbClientId.Text = "d13a8907c22450bcaea51c3218130691";
            // 
            // tbClientName
            // 
            this.tbClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientName.Location = new System.Drawing.Point(76, 36);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(274, 20);
            this.tbClientName.TabIndex = 3;
            this.tbClientName.Text = "Learning OAuth";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
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
            this.label2.Location = new System.Drawing.Point(6, 62);
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
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // btnRequestToken
            // 
            this.btnRequestToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRequestToken.Location = new System.Drawing.Point(22, 398);
            this.btnRequestToken.Name = "btnRequestToken";
            this.btnRequestToken.Size = new System.Drawing.Size(126, 23);
            this.btnRequestToken.TabIndex = 1;
            this.btnRequestToken.Text = "Get Request Token";
            this.btnRequestToken.UseVisualStyleBackColor = true;
            this.btnRequestToken.Click += new System.EventHandler(this.btnRequestToken_Click);
            // 
            // btnUserAuthorisation
            // 
            this.btnUserAuthorisation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUserAuthorisation.Location = new System.Drawing.Point(22, 427);
            this.btnUserAuthorisation.Name = "btnUserAuthorisation";
            this.btnUserAuthorisation.Size = new System.Drawing.Size(126, 23);
            this.btnUserAuthorisation.TabIndex = 2;
            this.btnUserAuthorisation.Text = "Get User Authorisation";
            this.btnUserAuthorisation.UseVisualStyleBackColor = true;
            this.btnUserAuthorisation.Click += new System.EventHandler(this.btnUserAuthorisation_Click);
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(397, 28);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(312, 481);
            this.browser.TabIndex = 3;
            // 
            // btnGetUrl
            // 
            this.btnGetUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetUrl.Location = new System.Drawing.Point(22, 456);
            this.btnGetUrl.Name = "btnGetUrl";
            this.btnGetUrl.Size = new System.Drawing.Size(126, 23);
            this.btnGetUrl.TabIndex = 4;
            this.btnGetUrl.Text = "Get Browser URL";
            this.btnGetUrl.UseVisualStyleBackColor = true;
            this.btnGetUrl.Click += new System.EventHandler(this.btnGetUrl_Click);
            // 
            // btnGetAccessToken
            // 
            this.btnGetAccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetAccessToken.Location = new System.Drawing.Point(22, 485);
            this.btnGetAccessToken.Name = "btnGetAccessToken";
            this.btnGetAccessToken.Size = new System.Drawing.Size(126, 23);
            this.btnGetAccessToken.TabIndex = 5;
            this.btnGetAccessToken.Text = "Get Access Token";
            this.btnGetAccessToken.UseVisualStyleBackColor = true;
            this.btnGetAccessToken.Click += new System.EventHandler(this.btnGetAccessToken_Click);
            // 
            // lblAuthToken
            // 
            this.lblAuthToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAuthToken.Location = new System.Drawing.Point(76, 262);
            this.lblAuthToken.Name = "lblAuthToken";
            this.lblAuthToken.Size = new System.Drawing.Size(274, 23);
            this.lblAuthToken.TabIndex = 15;
            this.lblAuthToken.Text = "---";
            this.lblAuthToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(76, 239);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(274, 23);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "---";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Auth. Token";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Name";
            // 
            // lblNsId
            // 
            this.lblNsId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNsId.Location = new System.Drawing.Point(76, 308);
            this.lblNsId.Name = "lblNsId";
            this.lblNsId.Size = new System.Drawing.Size(274, 23);
            this.lblNsId.TabIndex = 19;
            this.lblNsId.Text = "---";
            this.lblNsId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthSecret
            // 
            this.lblAuthSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAuthSecret.Location = new System.Drawing.Point(76, 285);
            this.lblAuthSecret.Name = "lblAuthSecret";
            this.lblAuthSecret.Size = new System.Drawing.Size(274, 23);
            this.lblAuthSecret.TabIndex = 18;
            this.lblAuthSecret.Text = "---";
            this.lblAuthSecret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "User ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Auth. Secret";
            // 
            // FlickrOauth2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGetAccessToken);
            this.Controls.Add(this.btnGetUrl);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.btnUserAuthorisation);
            this.Controls.Add(this.btnRequestToken);
            this.Controls.Add(this.groupBox1);
            this.Name = "FlickrOauth2";
            this.Size = new System.Drawing.Size(721, 525);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbClientSecret;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRequestToken;
        private System.Windows.Forms.Label lblRequestTokenSecret;
        private System.Windows.Forms.Label lblRequestToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUserAuthorisation;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button btnGetUrl;
        private System.Windows.Forms.Label lblVerifier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetAccessToken;
        private System.Windows.Forms.Label lblNsId;
        private System.Windows.Forms.Label lblAuthSecret;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAuthToken;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
