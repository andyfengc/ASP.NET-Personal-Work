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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //传值 
        public Button button;
        public Form2(ref Button button)
        {
            this.button = button;
            InitializeComponent();//初始化
            this.Width = 500;//初始宽度
            this.Height = 350;//初始高度           

            FlowLayoutPanel p1 = new FlowLayoutPanel();//申请一个新的控件
            p1.Width = 480;//宽度
            p1.Height = 300;//高度           
            p1.AutoScroll = true; //增加自动滚动条
            p1.FlowDirection = FlowDirection.TopDown;//自上而下的流布局
            p1.WrapContents = false;//不截断内容

            for (int i = 1; i <= 2; i++)
            {
                string str = "这是label" + i + "，本文是通过测试FlowLayoutPanel中控件的流布局方式进行显示的。此题是将Label中的内容进行换行显示，并采用垂直方式布局，在布局管理方式的过程中采用流中断机制进行控件内容自动换行，希望能够对学习这个方面的朋友有所帮助！";

                Label l1 = new Label();
                l1.Text = str;
                l1.AutoSize = true;    //设置AutoSize为可拉伸的 

                Label l2 = new Label();//用这个空白标签产生换行效果
                l2.Text = "";

                p1.Controls.Add(l1);//添加标签进容器
                p1.GetFlowBreak(l1);//获取流中断
                p1.Controls.Add(l2);//将标签添加入容器
                p1.GetFlowBreak(l2);//获取流中断
            }

            for (int n = 1; n <= 3; n++)
            {
                Button b1 = new Button();
                b1.Text = "这是第" + n + "个Button！";
                b1.AutoSize = true;
                p1.Controls.Add(b1);
                p1.GetFlowBreak(b1);//获取流中断
            }

            this.Controls.Add(p1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
