using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DeleteStudent : BaseForm
    {
        public DeleteStudent()
        {
            InitializeComponent();

            deleteButton.Click += deleteButton_Click;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (student_Id.Text == "")
            {
                MessageBox.Show("Please enter Student ID");
                return;
            }

            int studentId;

            if (!int.TryParse(student_Id.Text, out studentId))
            {
                MessageBox.Show("Student ID must be a number");
                return;
            }

            try
            {
                string query = $@"
                DELETE FROM Student
                WHERE Student_ID = {studentId}";

                DatabaseHelper.Execute(query);

                MessageBox.Show("Student Deleted Successfully ");

                student_Id.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {

        }
    }
}