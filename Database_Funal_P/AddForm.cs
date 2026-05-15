using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class AddForm : BaseForm
    {
        public AddForm()
        {
            InitializeComponent();

            StudentButton.Click += StudentButton_Click;
            TeacherButton.Click += TeacherButton_Click;
            ParentButton.Click += ParentButton_Click;
            CourseButton.Click += CourseButton_Click;
            AttendanceButton.Click += AttendanceButton_Click;
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();

            form.Show();

            this.Close();
        }
        private void TeacherButton_Click(object sender, EventArgs e)
        {
            AddTeacher form = new AddTeacher();

            form.Show();

            this.Close();
        }
        private void ParentButton_Click(object sender, EventArgs e)
        {
            AddParent form = new AddParent();

            form.Show();

            this.Close();
        }
        private void CourseButton_Click(object sender, EventArgs e)
        {
            AddCourse form = new AddCourse();

            form.Show();

            this.Close();
        }
        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            AddAtendance form = new AddAtendance();

            form.Show();

            this.Close();
        }
        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}