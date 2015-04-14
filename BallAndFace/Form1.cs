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
    public partial class Form1 : Form
    {
        private AnimateBall ball;
        private Thread ballThread;
        private AnimateFace face;
        private Thread faceThread;

        public Form1()
        {
            InitializeComponent();
            // add controls
            InitGui();
            // run ball
            RunBall();
            // run face
            RunFace();
        }

        private void RunFace()
        {
            faceThread = new Thread(new ThreadStart(face.Run));
            faceThread.Start();
        }

        private void RunBall()
        {
            ballThread = new Thread(new ThreadStart(ball.Run));
            ballThread.Start();
        }

        private void InitGui()
        {
            ball = new AnimateBall();
            ball.Show();
            face = new AnimateFace();
            face.Show();
            btnResumeBall.Enabled = false;
            btnResumeFace.Enabled = false;
        }


        private void btnStartFace_Click(object sender, EventArgs e)
        {
            face.Show();
            btnSuspendFace.Enabled = false;
            btnResumeFace.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnSuspendBall_Click(object sender, EventArgs e)
        {
            ballThread.Suspend();
            btnSuspendBall.Enabled = false;
            btnResumeBall.Enabled = true;
            btnRestartBall.Enabled = false;
        }

        private void btnResumeBall_Click(object sender, EventArgs e)
        {
            ballThread.Resume();
            btnResumeBall.Enabled = false;
            btnSuspendBall.Enabled = true;
            btnRestartBall.Enabled = true;
        }

        private void btnStopBall_Click(object sender, EventArgs e)
        {
            ballThread.Abort();
            btnStopBall.Enabled = false;
            btnSuspendBall.Enabled = false;
            btnResumeBall.Enabled = false;
            btnRestartBall.Enabled = true;
        }

        private void btnRestartBall_Click(object sender, EventArgs e)
        {
            ballThread.Abort();
            RunBall();
            btnSuspendBall.Enabled = true;
            btnResumeBall.Enabled = false;
            btnStopBall.Enabled = true;
        }

        private void btnSuspendFace_Click(object sender, EventArgs e)
        {
            faceThread.Suspend();
            btnSuspendFace.Enabled = false;
            btnResumeFace.Enabled = true;
            btnRestartFace.Enabled = false;
        }

        private void btnResumeFace_Click(object sender, EventArgs e)
        {
            faceThread.Resume();
            btnResumeFace.Enabled = false;
            btnSuspendFace.Enabled = true;
            btnRestartFace.Enabled = true;
        }

        private void btnStopFace_Click(object sender, EventArgs e)
        {
            faceThread.Abort();
            btnSuspendFace.Enabled = false;
            btnResumeFace.Enabled = false;
            btnStopFace.Enabled = false;
            btnRestartFace.Enabled = true;
        }

        private void btnRestartFace_Click(object sender, EventArgs e)
        {
            faceThread.Abort();
            RunFace();
            btnSuspendFace.Enabled = true;
            btnResumeFace.Enabled = false;
            btnStopFace.Enabled = true;
        }

    }

}
