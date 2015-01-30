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
        private delegate void ...// like list instance in java observer pattern
        
        public PublishForm()
        {
            InitializeComponent();
        }

        private void txtPublish_Click(object sender, EventArgs e)
        {
            // call delegate object.Invoke()
        }
    }
}
