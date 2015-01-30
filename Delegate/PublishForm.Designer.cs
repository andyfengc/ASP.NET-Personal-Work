namespace Delegate
{
    partial class PublishForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.txtPublish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(93, 38);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(239, 81);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.Text = "";
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(66, 146);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.Size = new System.Drawing.Size(75, 23);
            this.txtPublish.TabIndex = 3;
            this.txtPublish.Text = "Publish";
            this.txtPublish.UseVisualStyleBackColor = true;
            this.txtPublish.Click += new System.EventHandler(this.txtPublish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PublishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 182);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPublish);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Name = "PublishForm";
            this.Text = "Publish Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button txtPublish;
        private System.Windows.Forms.Button btnCancel;
    }
}