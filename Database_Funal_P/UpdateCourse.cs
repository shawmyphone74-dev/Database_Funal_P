using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class UpdateCourse : BaseForm
    {
        public UpdateCourse()
        {
            InitializeComponent();

            UpdateparentButton.Click += UpdateparentButton_Click;
        }

        private void UpdateparentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text != "")
                {
                    string query =
                    $@"UPDATE Course
                    SET Course_Name = '{name.Text}'
                    WHERE Course_ID = {course_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                if (credithour.Text != "")
                {
                    string query =
                    $@"UPDATE Course
                    SET Credit_Hours = {credithour.Text}
                    WHERE Course_ID = {course_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                MessageBox.Show("Course Updated Successfully ✔");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}