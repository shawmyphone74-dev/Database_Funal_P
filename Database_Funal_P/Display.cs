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
    public partial class Display : BaseForm
    {
        public Display()
        {
            InitializeComponent(); 
        StudentButton.Click += StudentButton_Click;
            TeacherButton.Click += TeacherButton_Click;
             AttendanceButton.Click += AttendanceButton_Click;
            CourseButton.Click += CourseButton_Click;
             ParentButton.Click += ParentButton_Click;
        }
        private void StudentButton_Click(object sender, EventArgs e)
        {
            DisplayStudent form = new DisplayStudent();
            form.Show();
            this.Close();
        }
        private void TeacherButton_Click(object sender, EventArgs e)
        {
            DisplayTeacher form = new DisplayTeacher();
            form.Show();
            this.Close();
        }
        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            DisplayAttendance form = new DisplayAttendance();
            form.Show();
            this.Close();
        }
        private void CourseButton_Click(object sender, EventArgs e)
        {
            DisplayCourse form = new DisplayCourse();
            form.Show();
            this.Close();
        }
        private void ParentButton_Click(object sender, EventArgs e)
        {
            DisplayParent form = new DisplayParent();
            form.Show();
            this.Close();
        }
    }
}
