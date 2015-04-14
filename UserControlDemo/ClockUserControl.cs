using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class ClockUserControl: UserControl
    {
        public ClockUserControl()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String time = DateTime.Now.ToLongDateString() + " : " + DateTime.Now.ToLongTimeString();
            lblTimer.Text = "Current Time: " + time;
        }
    }
}
