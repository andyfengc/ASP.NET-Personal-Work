using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBrowser.View
{
    interface IViewV2
    {
        string Path { get; }
        IList Folders { get; set; }
        IList Contents { get; set; }
        string selectedFolder { get; }
        string selectedFile { get; }

         event EventHandler displayFolderHandler;
         event EventHandler displayFolderContentHandler;
         event EventHandler openFileHandler;
        //delegate void EventHandler(object sender, EventArgs e);

        void OpenFile(string filePath);
    }
}
