using FileBrowser.Presenter;
using FileBrowser.View;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser
{
    public partial class FileBrowserForm : Form, IView
    {

        public FileBrowserForm()
        {
            InitializeComponent();
        }

        public string Path
        {
            get
            {
                return txtPath.Text;
            }
        }

        public IList Folders
        {
            get
            {
                return tvFolder.Nodes;
            }
        }

        public IList Contents
        {
            get
            {
                return lvContent.Items;
            }
        }

        private FileBrowserPresenter presenter;
        public FileBrowserPresenter Presenter
        {
            get
            {
                return this.presenter;
            }
            set
            {
                presenter = value;
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            // clear all nodes
            tvFolder.Nodes.Clear();

            // check if the directory entered by user exists
            // if it does then fill in the TreeView,
            // if not display error MessageBox
            if (Directory.Exists(txtPath.Text))
            {
                // add full path name to directoryTreeView 
                tvFolder.Nodes.Add(txtPath.Text);

                // insert subfolders
                Presenter.GetFolders(txtPath.Text, tvFolder.Nodes[0]);
            } // end if
            // display error MessageBox if directory not found
            else
                MessageBox.Show(txtPath.Text + " could not be found.",
                   "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } // end method enterButton_Click

        private void tvFolder_DoubleClick(object sender, EventArgs e)
        {
             var selectedItem = tvFolder.SelectedNode as TreeNode;
             //MessageBox.Show(selectedItem.FullPath);
           openFolder(selectedItem.FullPath);
        }

        private void openFolder(string path)
        {
            lvContent.Items.Clear();
            presenter.GetContent(path, lvContent.Items);
       }

        private void OpenFile(string path)
        {
            Process.Start(path);
        }

        private void lvContent_DoubleClick(object sender, EventArgs e)
        {
            if (lvContent.SelectedIndices.Count >  0){
                ListViewItem item = lvContent.SelectedItems[0];
                //MessageBox.Show(item.Text);
                string fullPath = item.Text;
                if (Directory.Exists(fullPath))
                {
                    //MessageBox.Show("is folder");
                    openFolder(fullPath);
                }
                if (File.Exists(fullPath))
                {
                    //MessageBox.Show("is file");
                    OpenFile(fullPath);
                }
            }
        }
    }
}
