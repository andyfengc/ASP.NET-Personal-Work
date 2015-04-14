using CourseManager.Model;
using CourseManager.Presenter;
using CourseManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManager
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

            // create a view
            CourseManagerForm view = new CourseManagerForm();
            // create a presenter
            CourseListPresenter presenter = new CourseListPresenter(view, new CourseDataAccess());

            Application.Run(view);
        }
    }
}
