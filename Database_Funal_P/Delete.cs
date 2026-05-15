using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class Delete : BaseForm
    {
        public Delete()
        {


            
            InitializeComponent();
            StudentButton.Click += StudentButton_Click;
            ParentButton.Click += ParentButton_Click;
            CourseButton.Click += CourseButton_Click;
            AttendanceButton.Click += AttendanceButton_Click;
            TeacherButton.Click += TeacherButton_Click;

        }
        private void StudentButton_Click(object sender, EventArgs e)
        {
            DeleteStudent form = new DeleteStudent(); 
            form.Show();
            this.Close();
        }
        private void ParentButton_Click(object sender, EventArgs e)
        {
            DeleteParent form = new DeleteParent(); 
            form.Show();
            this.Close();
        }
        private void CourseButton_Click(object sender, EventArgs e)
        {
            DeleteCourse form = new DeleteCourse(); 
            form.Show();
            this.Close();
        }
        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            DeleteAttendance form = new DeleteAttendance();
            form.Show();
            this.Close();
        }
        private void TeacherButton_Click(object sender, EventArgs e)
        {
            DeleteTeacher form = new DeleteTeacher();
            form.Show();
            this.Close();
        }
        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
