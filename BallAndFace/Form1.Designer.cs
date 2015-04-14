namespace BallAndFace
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbBall = new System.Windows.Forms.GroupBox();
            this.btnRestartBall = new System.Windows.Forms.Button();
            this.btnStopBall = new System.Windows.Forms.Button();
            this.btnSuspendBall = new System.Windows.Forms.Button();
            this.btnResumeBall = new System.Windows.Forms.Button();
            this.gbFace = new System.Windows.Forms.GroupBox();
            this.btnResumeFace = new System.Windows.Forms.Button();
            this.btnSuspendFace = new System.Windows.Forms.Button();
            this.btnStopFace = new System.Windows.Forms.Button();
            this.btnRestartFace = new System.Windows.Forms.Button();
            this.gbBall.SuspendLayout();
            this.gbFace.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBall
            // 
            this.gbBall.Controls.Add(this.btnRestartBall);
            this.gbBall.Controls.Add(this.btnStopBall);
            this.gbBall.Controls.Add(this.btnSuspendBall);
            this.gbBall.Controls.Add(this.btnResumeBall);
            this.gbBall.Location = new System.Drawing.Point(24, 26);
            this.gbBall.Name = "gbBall";
            this.gbBall.Size = new System.Drawing.Size(270, 70);
            this.gbBall.TabIndex = 1;
            this.gbBall.TabStop = false;
            this.gbBall.Text = "Ball controller";
            // 
            // btnRestartBall
            // 
            this.btnRestartBall.Location = new System.Drawing.Point(202, 31);
            this.btnRestartBall.Name = "btnRestartBall";
            this.btnRestartBall.Size = new System.Drawing.Size(54, 23);
            this.btnRestartBall.TabIndex = 7;
            this.btnRestartBall.Text = "Restart";
            this.btnRestartBall.UseVisualStyleBackColor = true;
            this.btnRestartBall.Click += new System.EventHandler(this.btnRestartBall_Click);
            // 
            // btnStopBall
            // 
            this.btnStopBall.Location = new System.Drawing.Point(141, 31);
            this.btnStopBall.Name = "btnStopBall";
            this.btnStopBall.Size = new System.Drawing.Size(55, 23);
            this.btnStopBall.TabIndex = 6;
            this.btnStopBall.Text = "Stop";
            this.btnStopBall.UseVisualStyleBackColor = true;
            this.btnStopBall.Click += new System.EventHandler(this.btnStopBall_Click);
            // 
            // btnSuspendBall
            // 
            this.btnSuspendBall.Location = new System.Drawing.Point(6, 31);
            this.btnSuspendBall.Name = "btnSuspendBall";
            this.btnSuspendBall.Size = new System.Drawing.Size(67, 23);
            this.btnSuspendBall.TabIndex = 5;
            this.btnSuspendBall.Text = "Suspend";
            this.btnSuspendBall.UseVisualStyleBackColor = true;
            this.btnSuspendBall.Click += new System.EventHandler(this.btnSuspendBall_Click);
            // 
            // btnResumeBall
            // 
            this.btnResumeBall.Location = new System.Drawing.Point(79, 31);
            this.btnResumeBall.Name = "btnResumeBall";
            this.btnResumeBall.Size = new System.Drawing.Size(56, 23);
            this.btnResumeBall.TabIndex = 4;
            this.btnResumeBall.Text = "Resume";
            this.btnResumeBall.UseVisualStyleBackColor = true;
            this.btnResumeBall.Click += new System.EventHandler(this.btnResumeBall_Click);
            // 
            // gbFace
            // 
            this.gbFace.Controls.Add(this.btnRestartFace);
            this.gbFace.Controls.Add(this.btnStopFace);
            this.gbFace.Controls.Add(this.btnResumeFace);
            this.gbFace.Controls.Add(this.btnSuspendFace);
            this.gbFace.Location = new System.Drawing.Point(376, 26);
            this.gbFace.Name = "gbFace";
            this.gbFace.Size = new System.Drawing.Size(282, 64);
            this.gbFace.TabIndex = 2;
            this.gbFace.TabStop = false;
            this.gbFace.Text = "Face controller";
            // 
            // btnResumeFace
            // 
            this.btnResumeFace.Location = new System.Drawing.Point(91, 31);
            this.btnResumeFace.Name = "btnResumeFace";
            this.btnResumeFace.Size = new System.Drawing.Size(55, 23);
            this.btnResumeFace.TabIndex = 4;
            this.btnResumeFace.Text = "Resume";
            this.btnResumeFace.UseVisualStyleBackColor = true;
            this.btnResumeFace.Click += new System.EventHandler(this.btnResumeFace_Click);
            // 
            // btnSuspendFace
            // 
            this.btnSuspendFace.Location = new System.Drawing.Point(15, 31);
            this.btnSuspendFace.Name = "btnSuspendFace";
            this.btnSuspendFace.Size = new System.Drawing.Size(70, 23);
            this.btnSuspendFace.TabIndex = 3;
            this.btnSuspendFace.Text = "Suspend";
            this.btnSuspendFace.UseVisualStyleBackColor = true;
            this.btnSuspendFace.Click += new System.EventHandler(this.btnSuspendFace_Click);
            // 
            // btnStopFace
            // 
            this.btnStopFace.Location = new System.Drawing.Point(152, 31);
            this.btnStopFace.Name = "btnStopFace";
            this.btnStopFace.Size = new System.Drawing.Size(52, 23);
            this.btnStopFace.TabIndex = 5;
            this.btnStopFace.Text = "Stop";
            this.btnStopFace.UseVisualStyleBackColor = true;
            this.btnStopFace.Click += new System.EventHandler(this.btnStopFace_Click);
            // 
            // btnRestartFace
            // 
            this.btnRestartFace.Location = new System.Drawing.Point(210, 31);
            this.btnRestartFace.Name = "btnRestartFace";
            this.btnRestartFace.Size = new System.Drawing.Size(59, 23);
            this.btnRestartFace.TabIndex = 6;
            this.btnRestartFace.Text = "Restart";
            this.btnRestartFace.UseVisualStyleBackColor = true;
            this.btnRestartFace.Click += new System.EventHandler(this.btnRestartFace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 108);
            this.Controls.Add(this.gbFace);
            this.Controls.Add(this.gbBall);
            this.Name = "Form1";
            this.Text = "Ball and Face";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbBall.ResumeLayout(false);
            this.gbFace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBall;
        private System.Windows.Forms.GroupBox gbFace;
        private System.Windows.Forms.Button btnSuspendBall;
        private System.Windows.Forms.Button btnResumeBall;
        private System.Windows.Forms.Button btnResumeFace;
        private System.Windows.Forms.Button btnSuspendFace;
        private System.Windows.Forms.Button btnStopBall;
        private System.Windows.Forms.Button btnRestartBall;
        private System.Windows.Forms.Button btnRestartFace;
        private System.Windows.Forms.Button btnStopFace;
    }
}

