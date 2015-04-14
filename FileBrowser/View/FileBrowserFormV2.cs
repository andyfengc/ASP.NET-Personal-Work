using FileBrowser.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser.View
{
    public partial class FileBrowserFormV2 : Form, IViewV2
    {
        public FileBrowserFormV2()
        {
            InitializeComponent();
        }

        public string Path
        {
            get { return txtPath.Text; }
        }




        private FileBrowserPresenter presenter;
        public Presenter.FileBrowserPresenter Presenter
        {
            get
            {
                return this.presenter;
            }
            set
            {
                this.presenter = value;
            }
        }

        public event EventHandler displayFolderHandler;

        public event EventHandler displayFolderContentHandler;

        public event EventHandler openFileHandler;


        public string selectedFolder
        {
            get { return tvFolder.SelectedNode.FullPath; }
        }


        System.Collections.IList IViewV2.Contents
        {
            get
            {
                return lbContent.Items;
            }
            set
            {
                lbContent.Items.Clear();
                foreach (var item in value)
                {
                    lbContent.Items.Add(item);
                }
            }
        }


        public string selectedFile
        {
            get { return lbContent.SelectedItem.ToString(); }
        }


        public void OpenFile(string filePath)
        {
            MessageBox.Show(filePath + "has been opened");
        }

        private void txtDisplay_Click(object sender, EventArgs e)
        {
            displayFolderHandler(sender, e);
        }

        private void tvFolder_DoubleClick(object sender, EventArgs e)
        {
            displayFolderContentHandler(sender, e);
        }

        private void lbContent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openFileHandler(sender, e);
        }

        System.Collections.IList IViewV2.Folders
        {
            get
            {
                return tvFolder.Nodes;
            }
            set
            {
                if (value.Count > 0)
                {

                    if (value[0] is TreeNode)
                    {
                        tvFolder.Nodes.Clear();
                        tvFolder.Nodes.Add((TreeNode)value[0]);
                    }
                }
            }
        }
    }
}
