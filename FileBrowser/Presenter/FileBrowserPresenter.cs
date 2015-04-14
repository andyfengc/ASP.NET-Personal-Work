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
    public class FileBrowserPresenter : FileBrowser.Presenter.IFileBrowserPresenter
    {
        private IView view;

        public FileBrowserPresenter(IView view)
        {
            this.view = view;
            view.Presenter = this;
        }

        public TreeNode GetFolders(string directoryValue, TreeNode parentNode)
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
        } // end method PopulateTreeView

        public void GetContent(string path, System.Windows.Forms.ListView.ListViewItemCollection items)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    string[] subfolders = Directory.GetDirectories(path);
                    var sortedSubfolders = subfolders.OrderBy( x => x).Select(x => x);
                    foreach (string folder in sortedSubfolders)
                    {
                        items.Add(folder);
                    }
                    string[] files = Directory.GetFiles(path);
                    foreach (string file in files.OrderBy(x=>x))
                    {
                        items.Add(file);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                items.Add("Access denied");
            }
        }
    }
}
