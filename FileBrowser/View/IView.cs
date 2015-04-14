using FileBrowser.Presenter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser.View
{
    public interface IView
    {
        string Path { get; }
        IList Folders { get; }
        IList Contents { get; }
        FileBrowserPresenter Presenter { get; set; }
    }
}
