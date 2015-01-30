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
    public partial class Form1 : Form
    {
        private SubscribeForm subsribeForm;
        private PublishForm publishForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void subscribeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             subsribeForm = new SubscribeForm();
            subsribeForm.Show();
        }

        private void publishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            publishForm = new PublishForm();
            publishForm.Show();
        }
    }
}
