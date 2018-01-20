namespace YTRTLS
{
    partial class main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.ytlogo = new System.Windows.Forms.PictureBox();
            this.yttagline = new System.Windows.Forms.Label();
            this.maincontrol = new System.Windows.Forms.TabControl();
            this.channelpage = new System.Windows.Forms.TabPage();
            this.videopage = new System.Windows.Forms.TabPage();
            this.url = new System.Windows.Forms.TextBox();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.allstatsvideo = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ytlogo2 = new System.Windows.Forms.PictureBox();
            this.ytrtls2 = new System.Windows.Forms.Label();
            this.url2 = new System.Windows.Forms.TextBox();
            this.pfp = new System.Windows.Forms.PictureBox();
            this.allstatschannel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ytlogo)).BeginInit();
            this.maincontrol.SuspendLayout();
            this.channelpage.SuspendLayout();
            this.videopage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytlogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).BeginInit();
            this.SuspendLayout();
            // 
            // ytlogo
            // 
            this.ytlogo.Image = ((System.Drawing.Image)(resources.GetObject("ytlogo.Image")));
            this.ytlogo.Location = new System.Drawing.Point(0, 0);
            this.ytlogo.Name = "ytlogo";
            this.ytlogo.Size = new System.Drawing.Size(127, 53);
            this.ytlogo.TabIndex = 0;
            this.ytlogo.TabStop = false;
            // 
            // yttagline
            // 
            this.yttagline.AutoSize = true;
            this.yttagline.Location = new System.Drawing.Point(7, 51);
            this.yttagline.Name = "yttagline";
            this.yttagline.Size = new System.Drawing.Size(105, 13);
            this.yttagline.TabIndex = 1;
            this.yttagline.Text = "Real Time Live Stats";
            this.yttagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maincontrol
            // 
            this.maincontrol.Controls.Add(this.channelpage);
            this.maincontrol.Controls.Add(this.videopage);
            this.maincontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maincontrol.Location = new System.Drawing.Point(0, 0);
            this.maincontrol.Name = "maincontrol";
            this.maincontrol.SelectedIndex = 0;
            this.maincontrol.Size = new System.Drawing.Size(230, 272);
            this.maincontrol.TabIndex = 2;
            // 
            // channelpage
            // 
            this.channelpage.Controls.Add(this.url2);
            this.channelpage.Controls.Add(this.pfp);
            this.channelpage.Controls.Add(this.allstatschannel);
            this.channelpage.Controls.Add(this.ytlogo2);
            this.channelpage.Controls.Add(this.ytrtls2);
            this.channelpage.Location = new System.Drawing.Point(4, 22);
            this.channelpage.Name = "channelpage";
            this.channelpage.Padding = new System.Windows.Forms.Padding(3);
            this.channelpage.Size = new System.Drawing.Size(222, 246);
            this.channelpage.TabIndex = 1;
            this.channelpage.Text = "Channel";
            this.channelpage.UseVisualStyleBackColor = true;
            // 
            // videopage
            // 
            this.videopage.Controls.Add(this.url);
            this.videopage.Controls.Add(this.thumbnail);
            this.videopage.Controls.Add(this.allstatsvideo);
            this.videopage.Controls.Add(this.ytlogo);
            this.videopage.Controls.Add(this.yttagline);
            this.videopage.Location = new System.Drawing.Point(4, 22);
            this.videopage.Name = "videopage";
            this.videopage.Padding = new System.Windows.Forms.Padding(3);
            this.videopage.Size = new System.Drawing.Size(222, 246);
            this.videopage.TabIndex = 0;
            this.videopage.Text = "Video";
            this.videopage.UseVisualStyleBackColor = true;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(4, 68);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(108, 20);
            this.url.TabIndex = 4;
            this.url.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // thumbnail
            // 
            this.thumbnail.Location = new System.Drawing.Point(133, 6);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(83, 50);
            this.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnail.TabIndex = 3;
            this.thumbnail.TabStop = false;
            // 
            // allstatsvideo
            // 
            this.allstatsvideo.AutoSize = true;
            this.allstatsvideo.Location = new System.Drawing.Point(3, 93);
            this.allstatsvideo.Name = "allstatsvideo";
            this.allstatsvideo.Size = new System.Drawing.Size(84, 143);
            this.allstatsvideo.TabIndex = 2;
            this.allstatsvideo.Text = "Title:\r\n\r\nDescription:\r\n\r\nViews:\r\n\r\nLikes:\r\n\r\nDislikes:\r\n\r\nComment count:";
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 16;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // tooltip
            // 
            this.tooltip.AutomaticDelay = 0;
            this.tooltip.AutoPopDelay = 0;
            this.tooltip.InitialDelay = 500;
            this.tooltip.IsBalloon = true;
            this.tooltip.ReshowDelay = 0;
            this.tooltip.UseFading = false;
            // 
            // ytlogo2
            // 
            this.ytlogo2.Image = ((System.Drawing.Image)(resources.GetObject("ytlogo2.Image")));
            this.ytlogo2.Location = new System.Drawing.Point(0, 0);
            this.ytlogo2.Name = "ytlogo2";
            this.ytlogo2.Size = new System.Drawing.Size(127, 53);
            this.ytlogo2.TabIndex = 2;
            this.ytlogo2.TabStop = false;
            // 
            // ytrtls2
            // 
            this.ytrtls2.AutoSize = true;
            this.ytrtls2.Location = new System.Drawing.Point(7, 51);
            this.ytrtls2.Name = "ytrtls2";
            this.ytrtls2.Size = new System.Drawing.Size(105, 13);
            this.ytrtls2.TabIndex = 3;
            this.ytrtls2.Text = "Real Time Live Stats";
            this.ytrtls2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // url2
            // 
            this.url2.Location = new System.Drawing.Point(6, 70);
            this.url2.Name = "url2";
            this.url2.Size = new System.Drawing.Size(108, 20);
            this.url2.TabIndex = 7;
            this.url2.TextChanged += new System.EventHandler(this.url2_TextChanged);
            // 
            // pfp
            // 
            this.pfp.Location = new System.Drawing.Point(135, 8);
            this.pfp.Name = "pfp";
            this.pfp.Size = new System.Drawing.Size(80, 80);
            this.pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfp.TabIndex = 6;
            this.pfp.TabStop = false;
            // 
            // allstatschannel
            // 
            this.allstatschannel.AutoSize = true;
            this.allstatschannel.Location = new System.Drawing.Point(5, 95);
            this.allstatschannel.Name = "allstatschannel";
            this.allstatschannel.Size = new System.Drawing.Size(65, 117);
            this.allstatschannel.TabIndex = 5;
            this.allstatschannel.Text = "Title:\r\n\r\nDescription:\r\n\r\nViews:\r\n\r\nSubscribers:\r\n\r\nVideos:";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(230, 272);
            this.Controls.Add(this.maincontrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YTRTLS";
            ((System.ComponentModel.ISupportInitialize)(this.ytlogo)).EndInit();
            this.maincontrol.ResumeLayout(false);
            this.channelpage.ResumeLayout(false);
            this.channelpage.PerformLayout();
            this.videopage.ResumeLayout(false);
            this.videopage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytlogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ytlogo;
        private System.Windows.Forms.Label yttagline;
        private System.Windows.Forms.TabControl maincontrol;
        private System.Windows.Forms.TabPage videopage;
        private System.Windows.Forms.TabPage channelpage;
        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Label allstatsvideo;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.TextBox url2;
        private System.Windows.Forms.PictureBox pfp;
        private System.Windows.Forms.Label allstatschannel;
        private System.Windows.Forms.PictureBox ytlogo2;
        private System.Windows.Forms.Label ytrtls2;
    }
}

