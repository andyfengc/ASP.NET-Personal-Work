using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.Model
{
    class CourseDataAccess
    {
        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course { CourseCode = "COMP212", CourseName = "Programming 3", Credit = 3, School = "SETAS/ICET" });
            courses.Add(new Course { CourseCode = "COMM170", CourseName = "Academic English 170", Credit = 2, School = "School of Advancement" });
            courses.Add(new Course { CourseCode = "COMP229", CourseName = "Advanced Web Applications", Credit = 2, School = "SETAS/ICET" });
            courses.Add(new Course { CourseCode = "COMP231", CourseName = "Computer Programmer Project", Credit = 2, School = "SETAS/ICET" });
            courses.Add(new Course { CourseCode = "COMP311", CourseName = "Software Testing & Quality", Credit = 2, School = "SETAS/ICET" });
            courses.Add(new Course { CourseCode = "COMP100", CourseName = "Programming 1", Credit = 3, School = "SETAS/ICET" });
            return courses;
        }
    }
}
