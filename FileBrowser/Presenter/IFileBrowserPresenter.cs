using System;
namespace FileBrowser.Presenter
{
    interface IFileBrowserPresenter
    {
        System.Windows.Forms.TreeNode GetFolders(string directoryValue, System.Windows.Forms.TreeNode parentNode);
    }
}
