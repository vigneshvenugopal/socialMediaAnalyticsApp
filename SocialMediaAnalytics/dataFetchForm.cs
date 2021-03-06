﻿using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SocialMediaAnalytics
{
    public partial class fetchSocailMediaData : Form
    {
        public string dir = Directory.GetCurrentDirectory() + "\\fetchData\\";

        public fetchSocailMediaData()
        {
            InitializeComponent();
        }

        private void Create_Param_Doc()
        {
            var fileName = "params.csv";
            var fileLocation = string.Format(dir + fileName);
            var csv = new StringBuilder();
            var line_1 = string.Format("{0},{1},{2}", "Parameter", "Value_1", "Value_2");
            csv.AppendLine(line_1);
            var line_2 = string.Format("{0},{1}", "Ad Name", adName.Text);
            csv.AppendLine(line_2);
            var line_3 = string.Format("{0},{1}", "Page ID", facebookPageID.Text);
            csv.AppendLine(line_3);
            var line_4 = string.Format("{0},{1}", "Page Name", facebookPageName.Text);
            csv.AppendLine(line_4);
            var line_5 = string.Format("{0},{1}", "Post Date", DateTime.Parse(adReleaseDate.Text).ToString("yyyy-MM-dd"));
            csv.AppendLine(line_5);
            var line_6 = string.Format("{0},{1}", "Next Date", DateTime.Parse(adReleaseDate.Text).AddDays(1).ToString("yyyy-MM-dd"));
            csv.AppendLine(line_6);
            var line_7 = string.Format("{0},{1}", "Post Type", facebookPostType.Text.ToLower());
            csv.AppendLine(line_7);
            var line_8 = string.Format("{0},{1}", "Hash Tag", twitterHashTag.Text);
            csv.AppendLine(line_8);
            var line_9 = string.Format("{0},{1}", "Official Handle", twitterOfficialHandle.Text.Replace("@", ""));
            csv.AppendLine(line_9);
            var line_10 = string.Format("{0},{1},{2}", "Tweets From", DateTime.Parse(adReleaseDate.Text).ToString("yyyy-MM-dd"), adReleaseDate.Text == null ? "0" : DateTime.Parse(adReleaseDate.Text).AddDays(1).ToString("yyyy-MM-dd")); 
            csv.AppendLine(line_10);
            var line_11 = string.Format("{0},{1}", "Tweets Till", DateTime.Now.ToString("yyyy-MM-dd"));
            csv.AppendLine(line_11);
            var line_12 = string.Format("{0},{1}", "Tweet Count", int.Parse(twitterNumberofTweets.Text));
            csv.AppendLine(line_12);
            var line_13 = string.Format("{0},{1}", "Video ID", youtubeVideoID.Text);
            csv.AppendLine(line_13);
            var line_14 = string.Format("{0},{1}", "Facebook API Key", facebookApiKey.Text);
            csv.AppendLine(line_14);
            var line_15 = string.Format("{0},{1}", "YouTube API Key", youtubeApiKey.Text);
            csv.AppendLine(line_15);

            File.WriteAllText(fileLocation, csv.ToString());
        }

        private void fetchDate_Click(object sender, System.EventArgs e)
        {
            Create_Param_Doc();
            System.Diagnostics.Process.Start(dir + "App.bat");
        }
    }
}
