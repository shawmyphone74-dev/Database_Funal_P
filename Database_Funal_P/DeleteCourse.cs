using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DeleteCourse : BaseForm
    {
        public DeleteCourse()
        {
            InitializeComponent();

            deleteButton.Click += deleteButton_Click;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (course_Id.Text == "")
            {
                MessageBox.Show("Enter Course ID");
                return;
            }

            try
            {
                string query = $@"
                DELETE FROM Course
                WHERE Course_ID = 
                {int.Parse(course_Id.Text)}";

                DatabaseHelper.Execute(query);

                MessageBox.Show("Deleted Successfully  ");

                course_Id.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}