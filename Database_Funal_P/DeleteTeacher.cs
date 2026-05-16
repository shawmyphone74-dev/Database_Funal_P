using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DeleteTeacher : BaseForm
    {
        public DeleteTeacher()
        {
            InitializeComponent();

            deleteButton.Click += deleteButton_Click;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (teacher_Id.Text == "")
            {
                MessageBox.Show("Enter Teacher ID");
                return;
            }

            int teacherId;

            if (!int.TryParse(teacher_Id.Text, out teacherId))
            {
                MessageBox.Show("Teacher ID must be a number");
                return;
            }

            try
            {
                string query = $@"

                UPDATE Teacher
                SET Manager_ID = NULL
                WHERE Manager_ID = {teacherId};

                DELETE FROM Teacher
                WHERE Teacher_ID = {teacherId}";

                DatabaseHelper.Execute(query);

                MessageBox.Show("Teacher Deleted Successfully ");

                teacher_Id.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}