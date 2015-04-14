using CourseManager.Model;
using CourseManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManager.Utils
{
    public partial class CourseManagerForm : Form, ICourseList
    {
        public CourseManagerForm()
        {
            InitializeComponent();
            LoadSearchType();
        }

        private void LoadSearchType()
        {
            foreach (SearchType type in Enum.GetValues(typeof(SearchType)))
            {
                chkSearchType.Items.Add(type);
            }
        }

        public List<Model.Course> Courses
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                lvCourses.Columns.Clear();
                lvCourses.Items.Clear();
                lvCourses.Columns.Add(SearchType.CourseCode.ToString(), 100);
                lvCourses.Columns.Add(SearchType.CourseName.ToString(), 150);
                lvCourses.Columns.Add(SearchType.Credit.ToString(), 50);
                lvCourses.Columns.Add(SearchType.School.ToString(), 200);
                foreach (Course course in value)
                {
                    ListViewItem item = new ListViewItem(new String[] { course.CourseCode, course.CourseName, course.Credit + "", course.School });
                    lvCourses.Items.Add(item);
                }
            }
        }

        public SearchType SearchType
        {
            get
            {
                this.Status = chkSearchType.SelectedItem.ToString();
                //return SearchType.CourseCode;
                return (SearchType)Enum.Parse(typeof(SearchType), chkSearchType.SelectedItem.ToString());
            }
        }

        public string SearchKeyword
        {
            get { return txtSearchKeyword.Text; }
        }

        public event EventHandler searchHandler;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchHandler(sender, e);
        }


        public string Status
        {
            get
            {
                return this.lblStatus.Text;
            }
            set
            {
                lblStatus.Text = value;
            }
        }
    }
}
