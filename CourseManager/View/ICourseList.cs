using CourseManager.Model;
using CourseManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.View
{
    interface ICourseList
    {
        List<Course> Courses { get; set; }
        SearchType SearchType { get; }
        string SearchKeyword { get; }
        string Status { get; set; }

        event EventHandler searchHandler;
    }
}
