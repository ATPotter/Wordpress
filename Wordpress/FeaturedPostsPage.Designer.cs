namespace Wordpress
{
    partial class FeaturedPostsPage
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
            this.btnGetAllPosts = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lvDisplay = new System.Windows.Forms.ListView();
            this.chPost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFeatured = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProposedFI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNumEntries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetAllPosts
            // 
            this.btnGetAllPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetAllPosts.Location = new System.Drawing.Point(13, 508);
            this.btnGetAllPosts.Name = "btnGetAllPosts";
            this.btnGetAllPosts.Size = new System.Drawing.Size(75, 23);
            this.btnGetAllPosts.TabIndex = 1;
            this.btnGetAllPosts.Text = "Get Posts";
            this.btnGetAllPosts.UseVisualStyleBackColor = true;
            this.btnGetAllPosts.Click += new System.EventHandler(this.btnGetAllPosts_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(94, 508);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(839, 23);
            this.progressBar.TabIndex = 2;
            // 
            // lvDisplay
            // 
            this.lvDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPost,
            this.chFeatured,
            this.chHeading,
            this.chProposedFI,
            this.chStatus});
            this.lvDisplay.GridLines = true;
            this.lvDisplay.Location = new System.Drawing.Point(13, 14);
            this.lvDisplay.Name = "lvDisplay";
            this.lvDisplay.Size = new System.Drawing.Size(1010, 487);
            this.lvDisplay.TabIndex = 3;
            this.lvDisplay.UseCompatibleStateImageBehavior = false;
            this.lvDisplay.View = System.Windows.Forms.View.Details;
            // 
            // chPost
            // 
            this.chPost.Text = "Post ID";
            // 
            // chFeatured
            // 
            this.chFeatured.Text = "Featured Img";
            this.chFeatured.Width = 200;
            // 
            // chHeading
            // 
            this.chHeading.Text = "Heading";
            this.chHeading.Width = 150;
            // 
            // chProposedFI
            // 
            this.chProposedFI.Text = "Proposed Featured";
            this.chProposedFI.Width = 200;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 25;
            // 
            // lblNumEntries
            // 
            this.lblNumEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumEntries.Location = new System.Drawing.Point(939, 507);
            this.lblNumEntries.Name = "lblNumEntries";
            this.lblNumEntries.Size = new System.Drawing.Size(84, 23);
            this.lblNumEntries.TabIndex = 4;
            this.lblNumEntries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FeaturedPostsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumEntries);
            this.Controls.Add(this.lvDisplay);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGetAllPosts);
            this.Name = "FeaturedPostsPage";
            this.Size = new System.Drawing.Size(1037, 542);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllPosts;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView lvDisplay;
        private System.Windows.Forms.ColumnHeader chPost;
        private System.Windows.Forms.ColumnHeader chFeatured;
        private System.Windows.Forms.ColumnHeader chHeading;
        private System.Windows.Forms.Label lblNumEntries;
        private System.Windows.Forms.ColumnHeader chProposedFI;
        private System.Windows.Forms.ColumnHeader chStatus;
    }
}
