using System.Net;

namespace AutoUpdateApp
{
    public partial class Form1 : Form
    {
        WebClient wb = new WebClient();
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
            //Checking if the user can get a response from "https://google.com/"
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
                //If it does not get a response (This means the user is offline or google is down for some reason) it will Exit the application, you can stop this by removing "Application.Exit();"
                MessageBox.Show("Offline");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string version = wb.DownloadString("HWID List URL");
        }
    }
}