using CourseManager.Model;
using CourseManager.Utils;
using CourseManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.Presenter
{
    class CourseListPresenter
    {
        private ICourseList view;
        private CourseDataAccess model;

        public CourseListPresenter(ICourseList view, CourseDataAccess model)
        {
            this.view = view;
            this.model = model;
            this.view.searchHandler += Search;
            LoadAllCourses();
        }

        private void Search(object sender, EventArgs e)
        {
            SearchType searchType = view.SearchType;
            string searchKeyword = view.SearchKeyword;
            List<Course> result = new List<Course>();

            foreach (Course course in model.GetAllCourses())
            {
                switch (searchType)
                {
                    case SearchType.CourseCode:
                        if (course.CourseCode.ToUpper().IndexOf(searchKeyword.ToUpper()) >= 0)
                            result.Add(course);
                        break;
                    case SearchType.CourseName:
                        if (course.CourseName.ToUpper().IndexOf(searchKeyword.ToUpper()) >= 0)
                        {
                            result.Add(course);
                        }
                        break;
                    case SearchType.Credit:
                        if (course.Credit == int.Parse(searchKeyword))
                        {
                            result.Add(course);
                        }
                        break;
                    case SearchType.School:
                        if (course.School.ToUpper().IndexOf(searchKeyword.ToUpper()) >= 0)
                            result.Add(course);
                        break;
                }
            }
            //result.Add(model.GetAllCourses().First());
            view.Courses = result;
            //view.Courses = result;
        }

        public void LoadAllCourses()
        {
            view.Courses = model.GetAllCourses();
        }
    }
}
