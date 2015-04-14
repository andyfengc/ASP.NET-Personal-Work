using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallAndFace
{
    public partial class AnimateBall : Form
    {
        private int x, y;
        private Button suspend = new Button();
        private Button resume = new Button();
        private Button abort = new Button();
        //Thread t;

        public AnimateBall()
        {
            BackColor = Color.White;
            Text = "Animate Ball";
            abort.Text = "Abort";
            suspend.Text = "Suspend";
            resume.Text = "Resume";

            int w = 20;
            suspend.Location = new Point(w, 200);
            resume.Location = new Point(w += 10 + suspend.Width, 200);
            abort.Location = new Point(w += 10 + resume.Width, 200);

            abort.Click += new EventHandler(Abort_Click);
            suspend.Click += new EventHandler(Suspend_Click);
            resume.Click += new EventHandler(Resume_Click);

            //Controls.Add(suspend);
            //Controls.Add(resume);
            //Controls.Add(abort);

            x = 50; y = 50;
            //t = new Thread(new ThreadStart(Run));
            //t.Start();
        }


        protected void Abort_Click(object sender, EventArgs e)
        {
            //t.Abort();
        }


        protected void Suspend_Click(object sender, EventArgs e)
        {
            //t.Suspend();
        }


        protected void Resume_Click(object sender, EventArgs e)
        {
            //t.Resume();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Red, x, y, 40, 40);
            base.OnPaint(e);
        }


        public void Run()
        {
            int dx = 9, dy = 9;
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    x += dx;
                    y += dy;
                    Invalidate();
                    Thread.Sleep(100);
                }
                dx = -dx; dy = -dy;
            }
        }
    }
}
