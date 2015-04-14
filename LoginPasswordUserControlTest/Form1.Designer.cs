namespace LoginPasswordUserControlTest
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
            this.loginPasswordUserControl1 = new LoginPasswordUserControl.LoginPasswordUserControl();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblUserNameResult = new System.Windows.Forms.Label();
            this.lblPasswordResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginPasswordUserControl1
            // 
            this.loginPasswordUserControl1.Location = new System.Drawing.Point(41, 13);
            this.loginPasswordUserControl1.Name = "loginPasswordUserControl1";
            this.loginPasswordUserControl1.Size = new System.Drawing.Size(286, 156);
            this.loginPasswordUserControl1.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(41, 175);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblUserNameResult
            // 
            this.lblUserNameResult.AutoSize = true;
            this.lblUserNameResult.Location = new System.Drawing.Point(164, 180);
            this.lblUserNameResult.Name = "lblUserNameResult";
            this.lblUserNameResult.Size = new System.Drawing.Size(0, 13);
            this.lblUserNameResult.TabIndex = 2;
            // 
            // lblPasswordResult
            // 
            this.lblPasswordResult.AutoSize = true;
            this.lblPasswordResult.Location = new System.Drawing.Point(164, 215);
            this.lblPasswordResult.Name = "lblPasswordResult";
            this.lblPasswordResult.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 252);
            this.Controls.Add(this.lblPasswordResult);
            this.Controls.Add(this.lblUserNameResult);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.loginPasswordUserControl1);
            this.Name = "Form1";
            this.Text = "LoginPasswordUserControl Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginPasswordUserControl.LoginPasswordUserControl loginPasswordUserControl1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblUserNameResult;
        private System.Windows.Forms.Label lblPasswordResult;

    }
}

