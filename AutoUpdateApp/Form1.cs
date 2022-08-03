using System.Net;
using System.Diagnostics;


namespace AutoUpdateApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkonline();
        }

            private void checkonline()
        {
            //Checking if the user have internet connection
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://google.com/"))
                    {
                    }
                }
            }
            catch
            {
                //If it does not get a intenet connection closing the app"
                MessageBox.Show("Offline");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                WebClient wb = new WebClient();
                string mainpath = "C:\\desktop\\updated.exe";
                string version = wb.DownloadString("version link here");
                if (version.Contains(label.Text))
                {
                    MessageBox.Show("You is Updated");
                }
                else
                {
                    MessageBox.Show("Outdated! Download new version");
                    //put here raw download of the update version          
                    wb.DownloadFile("updated link here", mainpath);
                    Process.Start(mainpath);
                    Application.Exit();
                }
            }
        }
    }
}