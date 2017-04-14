namespace SocialMediaAnalytics
{
    partial class fetchSocailMediaData
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
            this.adName = new System.Windows.Forms.TextBox();
            this.adNameLabel = new System.Windows.Forms.Label();
            this.facebookGroup = new System.Windows.Forms.GroupBox();
            this.postTypeLabel = new System.Windows.Forms.Label();
            this.facebookPostType = new System.Windows.Forms.ComboBox();
            this.postDateLabel = new System.Windows.Forms.Label();
            this.facebookPostDate = new System.Windows.Forms.DateTimePicker();
            this.facebookPageNameLabel = new System.Windows.Forms.Label();
            this.facebookPageName = new System.Windows.Forms.TextBox();
            this.facebookPageIDLabel = new System.Windows.Forms.Label();
            this.facebookPageID = new System.Windows.Forms.TextBox();
            this.twitterGroup = new System.Windows.Forms.GroupBox();
            this.twitterEndDate = new System.Windows.Forms.DateTimePicker();
            this.twitterEndDateLabel = new System.Windows.Forms.Label();
            this.twitterStartDateLabel = new System.Windows.Forms.Label();
            this.twitterStartDate = new System.Windows.Forms.DateTimePicker();
            this.twitterHandleLabel = new System.Windows.Forms.Label();
            this.twitterOfficialHandle = new System.Windows.Forms.TextBox();
            this.twitterHashTagLabel = new System.Windows.Forms.Label();
            this.twitterHashTag = new System.Windows.Forms.TextBox();
            this.youTubeGroup = new System.Windows.Forms.GroupBox();
            this.videoIDLabel = new System.Windows.Forms.Label();
            this.youtubeVideoID = new System.Windows.Forms.TextBox();
            this.fetchDate = new System.Windows.Forms.Button();
            this.facebookGroup.SuspendLayout();
            this.twitterGroup.SuspendLayout();
            this.youTubeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // adName
            // 
            this.adName.BackColor = System.Drawing.SystemColors.Window;
            this.adName.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.adName.Location = new System.Drawing.Point(102, 23);
            this.adName.Name = "adName";
            this.adName.Size = new System.Drawing.Size(200, 26);
            this.adName.TabIndex = 0;
            // 
            // adNameLabel
            // 
            this.adNameLabel.AutoSize = true;
            this.adNameLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adNameLabel.Location = new System.Drawing.Point(23, 27);
            this.adNameLabel.Name = "adNameLabel";
            this.adNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adNameLabel.Size = new System.Drawing.Size(65, 18);
            this.adNameLabel.TabIndex = 1;
            this.adNameLabel.Text = "Ad Name";
            // 
            // facebookGroup
            // 
            this.facebookGroup.Controls.Add(this.postTypeLabel);
            this.facebookGroup.Controls.Add(this.facebookPostType);
            this.facebookGroup.Controls.Add(this.postDateLabel);
            this.facebookGroup.Controls.Add(this.facebookPostDate);
            this.facebookGroup.Controls.Add(this.facebookPageNameLabel);
            this.facebookGroup.Controls.Add(this.facebookPageName);
            this.facebookGroup.Controls.Add(this.facebookPageIDLabel);
            this.facebookGroup.Controls.Add(this.facebookPageID);
            this.facebookGroup.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebookGroup.Location = new System.Drawing.Point(23, 81);
            this.facebookGroup.Name = "facebookGroup";
            this.facebookGroup.Size = new System.Drawing.Size(290, 225);
            this.facebookGroup.TabIndex = 2;
            this.facebookGroup.TabStop = false;
            this.facebookGroup.Text = "Facebook";
            // 
            // postTypeLabel
            // 
            this.postTypeLabel.AutoSize = true;
            this.postTypeLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postTypeLabel.Location = new System.Drawing.Point(39, 183);
            this.postTypeLabel.Name = "postTypeLabel";
            this.postTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.postTypeLabel.Size = new System.Drawing.Size(68, 18);
            this.postTypeLabel.TabIndex = 9;
            this.postTypeLabel.Text = "Post Type";
            // 
            // facebookPostType
            // 
            this.facebookPostType.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebookPostType.FormattingEnabled = true;
            this.facebookPostType.Items.AddRange(new object[] {
            "Link",
            "Photo",
            "Status",
            "Video"});
            this.facebookPostType.Location = new System.Drawing.Point(121, 180);
            this.facebookPostType.Name = "facebookPostType";
            this.facebookPostType.Size = new System.Drawing.Size(151, 26);
            this.facebookPostType.TabIndex = 8;
            // 
            // postDateLabel
            // 
            this.postDateLabel.AutoSize = true;
            this.postDateLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDateLabel.Location = new System.Drawing.Point(39, 138);
            this.postDateLabel.Name = "postDateLabel";
            this.postDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.postDateLabel.Size = new System.Drawing.Size(68, 18);
            this.postDateLabel.TabIndex = 7;
            this.postDateLabel.Text = "Post Date";
            // 
            // facebookPostDate
            // 
            this.facebookPostDate.CalendarFont = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebookPostDate.CustomFormat = "";
            this.facebookPostDate.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebookPostDate.Location = new System.Drawing.Point(121, 133);
            this.facebookPostDate.Name = "facebookPostDate";
            this.facebookPostDate.Size = new System.Drawing.Size(151, 21);
            this.facebookPostDate.TabIndex = 6;
            // 
            // facebookPageNameLabel
            // 
            this.facebookPageNameLabel.AutoSize = true;
            this.facebookPageNameLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebookPageNameLabel.Location = new System.Drawing.Point(28, 90);
            this.facebookPageNameLabel.Name = "facebookPageNameLabel";
            this.facebookPageNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.facebookPageNameLabel.Size = new System.Drawing.Size(79, 18);
            this.facebookPageNameLabel.TabIndex = 5;
            this.facebookPageNameLabel.Text = "Page Name";
            // 
            // facebookPageName
            // 
            this.facebookPageName.BackColor = System.Drawing.SystemColors.Window;
            this.facebookPageName.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebookPageName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.facebookPageName.Location = new System.Drawing.Point(121, 87);
            this.facebookPageName.Name = "facebookPageName";
            this.facebookPageName.Size = new System.Drawing.Size(151, 26);
            this.facebookPageName.TabIndex = 4;
            // 
            // facebookPageIDLabel
            // 
            this.facebookPageIDLabel.AutoSize = true;
            this.facebookPageIDLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebookPageIDLabel.Location = new System.Drawing.Point(51, 43);
            this.facebookPageIDLabel.Name = "facebookPageIDLabel";
            this.facebookPageIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.facebookPageIDLabel.Size = new System.Drawing.Size(56, 18);
            this.facebookPageIDLabel.TabIndex = 3;
            this.facebookPageIDLabel.Text = "Page ID";
            // 
            // facebookPageID
            // 
            this.facebookPageID.BackColor = System.Drawing.SystemColors.Window;
            this.facebookPageID.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebookPageID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.facebookPageID.Location = new System.Drawing.Point(121, 39);
            this.facebookPageID.Name = "facebookPageID";
            this.facebookPageID.Size = new System.Drawing.Size(151, 26);
            this.facebookPageID.TabIndex = 2;
            // 
            // twitterGroup
            // 
            this.twitterGroup.Controls.Add(this.twitterEndDate);
            this.twitterGroup.Controls.Add(this.twitterEndDateLabel);
            this.twitterGroup.Controls.Add(this.twitterStartDateLabel);
            this.twitterGroup.Controls.Add(this.twitterStartDate);
            this.twitterGroup.Controls.Add(this.twitterHandleLabel);
            this.twitterGroup.Controls.Add(this.twitterOfficialHandle);
            this.twitterGroup.Controls.Add(this.twitterHashTagLabel);
            this.twitterGroup.Controls.Add(this.twitterHashTag);
            this.twitterGroup.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterGroup.Location = new System.Drawing.Point(341, 81);
            this.twitterGroup.Name = "twitterGroup";
            this.twitterGroup.Size = new System.Drawing.Size(290, 225);
            this.twitterGroup.TabIndex = 10;
            this.twitterGroup.TabStop = false;
            this.twitterGroup.Text = "Twitter";
            // 
            // twitterEndDate
            // 
            this.twitterEndDate.CalendarFont = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterEndDate.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterEndDate.Location = new System.Drawing.Point(122, 180);
            this.twitterEndDate.Name = "twitterEndDate";
            this.twitterEndDate.Size = new System.Drawing.Size(151, 21);
            this.twitterEndDate.TabIndex = 10;
            // 
            // twitterEndDateLabel
            // 
            this.twitterEndDateLabel.AutoSize = true;
            this.twitterEndDateLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterEndDateLabel.Location = new System.Drawing.Point(35, 183);
            this.twitterEndDateLabel.Name = "twitterEndDateLabel";
            this.twitterEndDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.twitterEndDateLabel.Size = new System.Drawing.Size(73, 18);
            this.twitterEndDateLabel.TabIndex = 9;
            this.twitterEndDateLabel.Text = "Tweets Till";
            // 
            // twitterStartDateLabel
            // 
            this.twitterStartDateLabel.AutoSize = true;
            this.twitterStartDateLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterStartDateLabel.Location = new System.Drawing.Point(20, 138);
            this.twitterStartDateLabel.Name = "twitterStartDateLabel";
            this.twitterStartDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.twitterStartDateLabel.Size = new System.Drawing.Size(88, 18);
            this.twitterStartDateLabel.TabIndex = 7;
            this.twitterStartDateLabel.Text = "Tweets From";
            // 
            // twitterStartDate
            // 
            this.twitterStartDate.CalendarFont = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterStartDate.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterStartDate.Location = new System.Drawing.Point(122, 133);
            this.twitterStartDate.Name = "twitterStartDate";
            this.twitterStartDate.Size = new System.Drawing.Size(151, 21);
            this.twitterStartDate.TabIndex = 6;
            // 
            // twitterHandleLabel
            // 
            this.twitterHandleLabel.AutoSize = true;
            this.twitterHandleLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterHandleLabel.Location = new System.Drawing.Point(11, 90);
            this.twitterHandleLabel.Name = "twitterHandleLabel";
            this.twitterHandleLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.twitterHandleLabel.Size = new System.Drawing.Size(97, 18);
            this.twitterHandleLabel.TabIndex = 5;
            this.twitterHandleLabel.Text = "Official Handle";
            // 
            // twitterOfficialHandle
            // 
            this.twitterOfficialHandle.BackColor = System.Drawing.SystemColors.Window;
            this.twitterOfficialHandle.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterOfficialHandle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.twitterOfficialHandle.Location = new System.Drawing.Point(122, 87);
            this.twitterOfficialHandle.Name = "twitterOfficialHandle";
            this.twitterOfficialHandle.Size = new System.Drawing.Size(151, 26);
            this.twitterOfficialHandle.TabIndex = 4;
            // 
            // twitterHashTagLabel
            // 
            this.twitterHashTagLabel.AutoSize = true;
            this.twitterHashTagLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterHashTagLabel.Location = new System.Drawing.Point(44, 43);
            this.twitterHashTagLabel.Name = "twitterHashTagLabel";
            this.twitterHashTagLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.twitterHashTagLabel.Size = new System.Drawing.Size(64, 18);
            this.twitterHashTagLabel.TabIndex = 3;
            this.twitterHashTagLabel.Text = "Hash Tag";
            // 
            // twitterHashTag
            // 
            this.twitterHashTag.BackColor = System.Drawing.SystemColors.Window;
            this.twitterHashTag.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterHashTag.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.twitterHashTag.Location = new System.Drawing.Point(122, 39);
            this.twitterHashTag.Name = "twitterHashTag";
            this.twitterHashTag.Size = new System.Drawing.Size(151, 26);
            this.twitterHashTag.TabIndex = 2;
            // 
            // youTubeGroup
            // 
            this.youTubeGroup.Controls.Add(this.videoIDLabel);
            this.youTubeGroup.Controls.Add(this.youtubeVideoID);
            this.youTubeGroup.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youTubeGroup.Location = new System.Drawing.Point(659, 81);
            this.youTubeGroup.Name = "youTubeGroup";
            this.youTubeGroup.Size = new System.Drawing.Size(290, 225);
            this.youTubeGroup.TabIndex = 11;
            this.youTubeGroup.TabStop = false;
            this.youTubeGroup.Text = "YouTube";
            // 
            // videoIDLabel
            // 
            this.videoIDLabel.AutoSize = true;
            this.videoIDLabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoIDLabel.Location = new System.Drawing.Point(44, 43);
            this.videoIDLabel.Name = "videoIDLabel";
            this.videoIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.videoIDLabel.Size = new System.Drawing.Size(60, 18);
            this.videoIDLabel.TabIndex = 3;
            this.videoIDLabel.Text = "Video ID";
            // 
            // youtubeVideoID
            // 
            this.youtubeVideoID.BackColor = System.Drawing.SystemColors.Window;
            this.youtubeVideoID.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youtubeVideoID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.youtubeVideoID.Location = new System.Drawing.Point(122, 39);
            this.youtubeVideoID.Name = "youtubeVideoID";
            this.youtubeVideoID.Size = new System.Drawing.Size(151, 26);
            this.youtubeVideoID.TabIndex = 2;
            // 
            // fetchDate
            // 
            this.fetchDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchDate.Location = new System.Drawing.Point(463, 329);
            this.fetchDate.Name = "fetchDate";
            this.fetchDate.Size = new System.Drawing.Size(95, 29);
            this.fetchDate.TabIndex = 12;
            this.fetchDate.Text = "Fetch Data";
            this.fetchDate.UseVisualStyleBackColor = true;
            this.fetchDate.Click += new System.EventHandler(this.fetchDate_Click);
            // 
            // fetchSocailMediaData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(971, 385);
            this.Controls.Add(this.fetchDate);
            this.Controls.Add(this.youTubeGroup);
            this.Controls.Add(this.twitterGroup);
            this.Controls.Add(this.facebookGroup);
            this.Controls.Add(this.adNameLabel);
            this.Controls.Add(this.adName);
            this.Name = "fetchSocailMediaData";
            this.Text = "Fetch Socail Media Data";
            this.facebookGroup.ResumeLayout(false);
            this.facebookGroup.PerformLayout();
            this.twitterGroup.ResumeLayout(false);
            this.twitterGroup.PerformLayout();
            this.youTubeGroup.ResumeLayout(false);
            this.youTubeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adName;
        private System.Windows.Forms.Label adNameLabel;
        private System.Windows.Forms.GroupBox facebookGroup;
        private System.Windows.Forms.Label facebookPageNameLabel;
        private System.Windows.Forms.TextBox facebookPageName;
        private System.Windows.Forms.Label facebookPageIDLabel;
        private System.Windows.Forms.TextBox facebookPageID;
        private System.Windows.Forms.Label postDateLabel;
        private System.Windows.Forms.DateTimePicker facebookPostDate;
        private System.Windows.Forms.ComboBox facebookPostType;
        private System.Windows.Forms.Label postTypeLabel;
        private System.Windows.Forms.GroupBox twitterGroup;
        private System.Windows.Forms.Label twitterEndDateLabel;
        private System.Windows.Forms.Label twitterStartDateLabel;
        private System.Windows.Forms.DateTimePicker twitterStartDate;
        private System.Windows.Forms.Label twitterHandleLabel;
        private System.Windows.Forms.TextBox twitterOfficialHandle;
        private System.Windows.Forms.Label twitterHashTagLabel;
        private System.Windows.Forms.TextBox twitterHashTag;
        private System.Windows.Forms.DateTimePicker twitterEndDate;
        private System.Windows.Forms.GroupBox youTubeGroup;
        private System.Windows.Forms.Label videoIDLabel;
        private System.Windows.Forms.TextBox youtubeVideoID;
        private System.Windows.Forms.Button fetchDate;
    }
}

