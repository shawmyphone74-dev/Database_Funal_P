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
    public partial class Update : BaseForm
    {
        public Update()
        {
            InitializeComponent(); 
            StudentButton.Click += StudentButton_Click;
            ParentButton.Click += ParentButton_Click;
            TeacherButton.Click += TeacherButton_Click;
            CourseButton.Click += CourseButton_Click;
            AttendanceButton.Click += AttendanceButton_Click;
        }
        private void StudentButton_Click(object sender, EventArgs e)

        {

            UpdateStudent form = new UpdateStudent();

            form.Show();

            this.Close();
        }
        private void ParentButton_Click(object sender, EventArgs e)

        {

            UpdateParent form = new UpdateParent();

            form.Show();

            this.Close();
        }
        private void TeacherButton_Click(object sender, EventArgs e)

        {

            UpdateTeacher form = new UpdateTeacher();

            form.Show();

            this.Close();
        }
        private void CourseButton_Click(object sender, EventArgs e)

        {

            UpdateCourse form = new UpdateCourse();

            form.Show();

            this.Close();
        }
        private void AttendanceButton_Click(object sender, EventArgs e)

        {

            UpdateAttendance form = new UpdateAttendance();

            form.Show();

            this.Close();
        }
    }
}
