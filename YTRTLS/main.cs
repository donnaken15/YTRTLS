using System.Windows.Forms;

namespace YTRTLS
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            url.Text = System.Environment.GetCommandLineArgs()[1];
        }
        
        private void update_Tick(object sender, System.EventArgs e)
        {

        }

        private void url_TextChanged(object sender, System.EventArgs e)
        {
            url.Text = url.Text.Replace("https", "").Replace("http", "").Replace("://", "").Replace("www.", "").Replace("youtube.com/", "").Replace("watch?v=", "").Replace("v/", "").Replace("youtu.be/", "").Replace(SubstringExtensions.After(url.Text, "&"), "").Replace("&", "");
        }
    }
}
