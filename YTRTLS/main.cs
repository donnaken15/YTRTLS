using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;

namespace YTRTLS
{
    public partial class main : Form
    {
        private static string vidinfo;

        private static string userinfo;

        private static WebClient metadata = new WebClient();

        public main()
        {
            InitializeComponent();
            try
            {
                if (System.Environment.GetCommandLineArgs()[1] != "")
                {
                    url.Text = System.Environment.GetCommandLineArgs()[1];
                }
            }
            catch { }
        }
        
        private void update_Tick(object sender, System.EventArgs e)
        {
            try
            {
                thumbnail.Load("http://i.ytimg.com/vi/" + url.Text + "/default.jpg");
            }
            catch { }
            if (url.Text != "")
            {
                try
                {
                    vidinfo = metadata.DownloadString("https://www.googleapis.com/youtube/v3/videos?id=" + url.Text + "&part=snippet,contentDetails,statistics&key=AIzaSyB8huSbFxBlMdpbKCC1DjeQPPOt96obnfY");
                    allstatsvideo.Text = @"Title: " + SubstringExtensions.Between(vidinfo, "\"title\": \"", "\",\n    \"description\": \"") + @"

Description: " + SubstringExtensions.Between(vidinfo, "\"description\": \"", "\",\n    \"thumbnails\": {") + @"

Views: " + SubstringExtensions.Between(vidinfo, "\"viewCount\": \"", "\",\n    \"likeCount\": \"") + @"

Likes: " + SubstringExtensions.Between(vidinfo, "\"likeCount\": \"", "\",\n    \"dislikeCount\": \"") + @"

Dislikes: " + SubstringExtensions.Between(vidinfo, "\"dislikeCount\": \"", "\",\n    \"favoriteCount\": \"") + @"

Comment count:  " + SubstringExtensions.Between(vidinfo, "\"commentCount\": \"", "\"\n   }\n  }\n ]") + @"";
                }
                catch { }
            }
            try
            {
                userinfo = metadata.DownloadString("https://www.googleapis.com/youtube/v3/channels?id=" + url2.Text + "&part=snippet,contentDetails,statistics&key=AIzaSyB8huSbFxBlMdpbKCC1DjeQPPOt96obnfY").Replace("\\n", Environment.NewLine);
                string subscribers_check_hide = "0";
                if (userinfo.Contains("\"hiddenSubscriberCount\": false,")) { subscribers_check_hide = SubstringExtensions.Between(userinfo, "\"subscriberCount\": \"", "\",\n    \"hiddenSubscriberCount\": \""); } else { subscribers_check_hide = "[REDACTED]"; }
                pfp.Load(SubstringExtensions.Between(userinfo, "    \"thumbnails\": {\n     \"default\": {\n      \"url\": \"", "\"\n     },"));
                allstatschannel.Text = @"Title: " + SubstringExtensions.Between(userinfo, "\"title\": \"", "\",\n    \"description\": \"") + @"

Description: " + SubstringExtensions.Between(userinfo, "\"description\": \"", "\",\n    \"customUrl\": \"") + @"

Views: " + SubstringExtensions.Between(userinfo, "\"viewCount\": \"", "\",\n    \"commentCount\": \"") + @"

Subscribers: " + subscribers_check_hide + @"

Videos: " + SubstringExtensions.Between(userinfo, "\"videoCount\": \"", "\"\n   }\n  }\n ]");
            }
            catch { }

        }

        private void url_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                url.Text = url.Text.Replace("https", "").Replace("http", "").Replace("://", "").Replace("www.", "").Replace("youtube.com/", "").Replace("watch?v=", "").Replace("v/", "").Replace("youtu.be/", "");
                url.Text = url.Text.Replace(SubstringExtensions.After(url.Text, "&"), "").Replace("&", "");
            }
            catch { }
            try
            {
                vidinfo = metadata.DownloadString("https://www.googleapis.com/youtube/v3/videos?id=" + url.Text + "&part=snippet,contentDetails,statistics&key=AIzaSyB8huSbFxBlMdpbKCC1DjeQPPOt96obnfY").Replace("\\n", Environment.NewLine);
                allstatsvideo.Text = @"Title: " + SubstringExtensions.Between(vidinfo, "\"title\": \"", "\",\n    \"description\": \"") + @"

Description: " + SubstringExtensions.Between(vidinfo, "\"description\": \"", "\",\n    \"thumbnails\": {") + @"

Views: " + SubstringExtensions.Between(vidinfo, "\"viewCount\": \"", "\",\n    \"likeCount\": \"") + @"

Likes: " + SubstringExtensions.Between(vidinfo, "\"likeCount\": \"", "\",\n    \"dislikeCount\": \"") + @"

Dislikes: " + SubstringExtensions.Between(vidinfo, "\"dislikeCount\": \"", "\",\n    \"favoriteCount\": \"") + @"

Comment count:  " + SubstringExtensions.Between(vidinfo, "\"commentCount\": \"", "\"\n   }\n  }\n ]") + @"";
            }
            catch { }
            tooltip.SetToolTip(allstatsvideo, allstatsvideo.Text);
        }

        private void url2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                url2.Text = url2.Text.Replace("https", "").Replace("http", "").Replace("://", "").Replace("www.", "").Replace("youtube.com/", "").Replace("channel/", "").Replace("c/", "").Replace("user/", "").Replace("u/","");
                url2.Text = url2.Text.Replace(SubstringExtensions.After(url.Text, "&"), "").Replace("&", "");
            }
            catch { }
            try
            {
                userinfo = metadata.DownloadString("https://www.googleapis.com/youtube/v3/channels?id=" + url2.Text + "&part=snippet,contentDetails,statistics&key=AIzaSyB8huSbFxBlMdpbKCC1DjeQPPOt96obnfY").Replace("\\n", " ");
                string subscribers_check_hide = "0";
                if (userinfo.Contains("\"hiddenSubscriberCount\": false,")) { subscribers_check_hide = SubstringExtensions.Between(userinfo, "\"subscriberCount\": \"", "\",\n    \"hiddenSubscriberCount\": "); } else { subscribers_check_hide = "[REDACTED]"; }
                //pfp.Load(SubstringExtensions.Between(userinfo, "\"url\": \"", "\"\n     },"));
                allstatschannel.Text = @"Title: " + SubstringExtensions.Between(userinfo, "\"title\": \"", "\",\n    \"description\": \"") + @"

Description: " + SubstringExtensions.Between(userinfo, "\"description\": \"", "\",\n    \"customUrl\": \"") + @"

Views: " + SubstringExtensions.Between(userinfo, "\"viewCount\": \"", "\",\n    \"commentCount\": \"") + @"

Subscribers: " + subscribers_check_hide + @"

Videos: " + SubstringExtensions.Between(userinfo, "\"videoCount\": \"", "\"\n   }\n  }\n ]");
            }
            catch { }
            tooltip.SetToolTip(allstatschannel, allstatschannel.Text);
        }
    }
}
