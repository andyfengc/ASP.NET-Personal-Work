using FileBrowser.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser.Presenter
{
    class FileBrowserPresenterV2 : IFileBrowserPresenter
    {
        private IViewV2 view;

        public FileBrowserPresenterV2(IViewV2 view)
        {
            this.view = view;
            // add event handlers
            view.displayFolderHandler += LoadFolderList;
            view.displayFolderContentHandler += LoadFolderContent;
            view.openFileHandler += OpenFile;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            view.OpenFile(view.selectedFile);
        }

        private void LoadFolderContent(object sender, EventArgs e)
        {
            view.Contents = GetContent(view.selectedFolder);
        }
        private IList GetContent(string path)
        {
            IList list = new ArrayList();
            try
            {
                if (Directory.Exists(path))
                {
                    string[] subfolders = Directory.GetDirectories(path);
                    var sortedSubfolders = subfolders.OrderBy(x => x).Select(x => x);
                    foreach (string folder in sortedSubfolders)
                    {
                        list.Add(folder);
                    }
                    string[] files = Directory.GetFiles(path);
                    foreach (string file in files.OrderBy(x => x))
                    {
                        list.Add(file);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                list.Add("Access denied");
            }
            return list;
        }

        private void LoadFolderList(object sender, EventArgs e)
        {
            //// way 1: directly access the internal member of view object, discouraged
            //if (view.Folders is TreeNodeCollection)
            //{
            //    var folders = (TreeNodeCollection)view.Folders;
            //    folders.Clear();
            //    folders.Add(view.Path);
            //    GetFolders(view.Path, folders[0]);
            //}

            // way 2: interact with view through interface, recommend
            view.Folders.Clear();
            TreeNode node = new TreeNode(view.Path);
            IList list = new ArrayList();
            list.Add(GetFolders(view.Path, node));
            view.Folders = list;
        }

        public System.Windows.Forms.TreeNode GetFolders(string directoryValue, System.Windows.Forms.TreeNode parentNode)
        {
            // array stores all subdirectories in the directory
            string[] directoryArray = Directory.GetDirectories(directoryValue);
            try
            {
                if (directoryArray.Length != 0)
                {
                    // for every subdirectory, create new TreeNode,
                    // add as a child of current node and recursively
                    // populate child nodes with subdirectories
                    foreach (string directory in directoryArray)
                    {
                        // obtain last part of path name from the full path 
                        // name by calling the GetFileNameWithoutExtension
                        // method of class Path
                        string substringDirectory = Path.GetFileNameWithoutExtension(directory);

                        // create TreeNode for current directory
                        TreeNode myNode = new TreeNode(substringDirectory);

                        // add current directory node to parent node
                        parentNode.Nodes.Add(myNode);

                        // recursively populate every subdirectory
                        GetFolders(directory, myNode);
                    } // end foreach
                } // end if
            } // end try

            // catch exception
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            } // end catch
            return parentNode;
        }


    }
}
