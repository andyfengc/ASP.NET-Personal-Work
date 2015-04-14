using FileBrowser.Presenter;
using FileBrowser.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //// v1: inject presenter object to view object
            //// view
            //FileBrowserForm fbForm = new FileBrowserForm();
            //// presenter
            //FileBrowserPresenter presenter = new FileBrowserPresenter(fbForm);
            //Application.Run(fbForm);

            // v2: define multiple event handlers of view object in presenter object
            // view
            FileBrowserFormV2 view = new FileBrowserFormV2();
            //presenter 
            IFileBrowserPresenter presenter = new FileBrowserPresenterV2(view);
            Application.Run(view);
        }
    }
}
