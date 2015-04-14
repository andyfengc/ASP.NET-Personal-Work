namespace FileBrowser.View
{
    partial class FileBrowserFormV2
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.Button();
            this.tvFolder = new System.Windows.Forms.TreeView();
            this.lbContent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(13, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(472, 20);
            this.txtPath.TabIndex = 0;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(502, 11);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(75, 23);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "Display";
            this.txtDisplay.UseVisualStyleBackColor = true;
            this.txtDisplay.Click += new System.EventHandler(this.txtDisplay_Click);
            // 
            // tvFolder
            // 
            this.tvFolder.Location = new System.Drawing.Point(13, 52);
            this.tvFolder.Name = "tvFolder";
            this.tvFolder.Size = new System.Drawing.Size(158, 378);
            this.tvFolder.TabIndex = 2;
            this.tvFolder.DoubleClick += new System.EventHandler(this.tvFolder_DoubleClick);
            // 
            // lbContent
            // 
            this.lbContent.FormattingEnabled = true;
            this.lbContent.Location = new System.Drawing.Point(192, 52);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(373, 381);
            this.lbContent.TabIndex = 3;
            this.lbContent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbContent_MouseDoubleClick);
            // 
            // FileBrowserFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 487);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.tvFolder);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtPath);
            this.Name = "FileBrowserFormV2";
            this.Text = "FileBrowserFormV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button txtDisplay;
        private System.Windows.Forms.TreeView tvFolder;
        private System.Windows.Forms.ListBox lbContent;
    }
}