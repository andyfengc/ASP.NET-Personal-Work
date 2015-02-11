using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class PublishForm : Form
    {
        private MainForm server;

        public PublishForm(MainForm server)
        {
            InitializeComponent();
            this.server = server;
        }

        private void txtPublish_Click(object sender, EventArgs e)
        {
            // get message
            string message = txtMessage.Text;
            // publish message through server
            server.Publish(message);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
