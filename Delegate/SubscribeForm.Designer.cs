namespace Delegate
{
    partial class SubscribeForm
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
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkMobile = new System.Windows.Forms.CheckBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(28, 53);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(133, 17);
            this.chkEmail.TabIndex = 0;
            this.chkEmail.Text = "Message sent by email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // chkMobile
            // 
            this.chkMobile.AutoSize = true;
            this.chkMobile.Location = new System.Drawing.Point(28, 92);
            this.chkMobile.Name = "chkMobile";
            this.chkMobile.Size = new System.Drawing.Size(139, 17);
            this.chkMobile.TabIndex = 2;
            this.chkMobile.Text = "Message sent by mobile";
            this.chkMobile.UseVisualStyleBackColor = true;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(167, 92);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(184, 20);
            this.txtMobile.TabIndex = 3;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(41, 142);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 4;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(151, 142);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnUnsubscribe.TabIndex = 5;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 187);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.chkMobile);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkEmail);
            this.Name = "SubscribeForm";
            this.Text = "Subscribe Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnCancel;
    }
}