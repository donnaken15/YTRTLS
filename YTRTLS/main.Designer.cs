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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.ytlogo = new System.Windows.Forms.PictureBox();
            this.yttagline = new System.Windows.Forms.Label();
            this.maincontrol = new System.Windows.Forms.TabControl();
            this.channelpage = new System.Windows.Forms.TabPage();
            this.videopage = new System.Windows.Forms.TabPage();
            this.allstatsvideo = new System.Windows.Forms.Label();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ytlogo)).BeginInit();
            this.maincontrol.SuspendLayout();
            this.channelpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
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
            this.maincontrol.Size = new System.Drawing.Size(251, 334);
            this.maincontrol.TabIndex = 2;
            // 
            // channelpage
            // 
            this.channelpage.Controls.Add(this.thumbnail);
            this.channelpage.Controls.Add(this.allstatsvideo);
            this.channelpage.Controls.Add(this.ytlogo);
            this.channelpage.Controls.Add(this.yttagline);
            this.channelpage.Location = new System.Drawing.Point(4, 22);
            this.channelpage.Name = "channelpage";
            this.channelpage.Padding = new System.Windows.Forms.Padding(3);
            this.channelpage.Size = new System.Drawing.Size(243, 308);
            this.channelpage.TabIndex = 0;
            this.channelpage.Text = "Channel";
            this.channelpage.UseVisualStyleBackColor = true;
            // 
            // videopage
            // 
            this.videopage.Location = new System.Drawing.Point(4, 22);
            this.videopage.Name = "videopage";
            this.videopage.Padding = new System.Windows.Forms.Padding(3);
            this.videopage.Size = new System.Drawing.Size(359, 336);
            this.videopage.TabIndex = 1;
            this.videopage.Text = "Video";
            this.videopage.UseVisualStyleBackColor = true;
            // 
            // allstatsvideo
            // 
            this.allstatsvideo.AutoSize = true;
            this.allstatsvideo.Location = new System.Drawing.Point(17, 73);
            this.allstatsvideo.Name = "allstatsvideo";
            this.allstatsvideo.Size = new System.Drawing.Size(84, 143);
            this.allstatsvideo.TabIndex = 2;
            this.allstatsvideo.Text = "Title:\r\n\r\nDescription:\r\n\r\nViews:\r\n\r\nLikes:\r\n\r\nDislikes:\r\n\r\nComment count:";
            // 
            // thumbnail
            // 
            this.thumbnail.Location = new System.Drawing.Point(134, 7);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(100, 50);
            this.thumbnail.TabIndex = 3;
            this.thumbnail.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(251, 334);
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
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ytlogo;
        private System.Windows.Forms.Label yttagline;
        private System.Windows.Forms.TabControl maincontrol;
        private System.Windows.Forms.TabPage channelpage;
        private System.Windows.Forms.TabPage videopage;
        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Label allstatsvideo;
    }
}

