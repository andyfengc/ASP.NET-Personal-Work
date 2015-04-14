using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTestForm
{
    public partial class Form1 : Form
    {
        TableLayoutPanel tblLayout1 = new TableLayoutPanel();
        TableLayoutPanel tblLayout2 = new TableLayoutPanel();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //隐藏当前窗体
            this.Hide();
            //新建另一个窗体
            Form2 form2 = new Form2(ref button1);
            form2.Show();

        }


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = 1000;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tblLayout1.ColumnCount = 3;
            MessageBox.Show("e");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tblLayout1.ColumnCount = 2;
        }

    }
}
