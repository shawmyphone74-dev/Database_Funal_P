using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class AddCourse : BaseForm
    {
        public AddCourse()
        {
            InitializeComponent();

            AddButton.Click += AddButton_Click;
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (course_id.Text == "" ||
                coursename.Text == "" ||
                credithour.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            int courseId;
            int creditHours;
            
            if (!int.TryParse(course_id.Text, out courseId))
            {
                MessageBox.Show("Course ID must be a number");
                return;
            }

            if (!int.TryParse(credithour.Text, out creditHours))
            {
                MessageBox.Show("Credit Hours must be a number");
                return;
            }

            if (creditHours <= 0)
            {
                MessageBox.Show("Credit Hours must be greater than 0");
                return;
            }

            try
            {
                string query = $@"
                INSERT INTO Course
                (
                    Course_ID,
                    Course_Name,
                    Credit_Hours
                )
                VALUES
                (
                    {courseId},
                    '{coursename.Text}',
                    {creditHours}
                )";

                DatabaseHelper.Execute(query);

                MessageBox.Show("Course Added Successfully  ");

                course_id.Clear();
                coursename.Clear();
                credithour.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}