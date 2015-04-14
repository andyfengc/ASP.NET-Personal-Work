using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            txtContent.Text += "Called from button event handler.....\r\n";

            string contentLength = await AccessTheWebAsync();

            txtContent.Text += string.Format("\r\nThe downloaded content: {0}. \r\n", contentLength);

        }

        private async Task<string> AccessTheWebAsync()
        {
            HttpClient client = new HttpClient();

            Task<string> getStringTask = client.GetStringAsync("http://www.centennialcollege.ca");

            // do not wait and do other work 
            DoIndependentWork();

            // suspend here and wait until getStringTask method is done
            string urlContents = await getStringTask;

            return urlContents.ToString();
        }

        private void DoIndependentWork()
        {
            txtContent.Text += "Working.....\r\n";
        }


    }
}
