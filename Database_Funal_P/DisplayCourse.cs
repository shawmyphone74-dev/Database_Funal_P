
using System.Data;

using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DisplayCourse : BaseForm
    {
        public DisplayCourse()
        {
            InitializeComponent();

            SearchButton.Click += SearchButton_Click;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                if (SearchType.Text == "All Courses")
                {
                    query =
                    "SELECT * FROM Course";
                }

                else if (SearchType.Text == "Course ID")
                {
                    query =
                    $"SELECT * FROM Course " +
                    $"WHERE Course_ID = {SearchText.Text}";
                }

                else if (SearchType.Text == "Course Name")
                {
                    query =
                    $"SELECT * FROM Course " +
                    $"WHERE Course_Name = '{SearchText.Text}'";
                }

                else if (SearchType.Text == "Credit Hours")
                {
                    query =
                    $"SELECT * FROM Course " +
                    $"WHERE Credit_Hours = {SearchText.Text}";
                }

                DataTable dt =
                    DatabaseHelper.GetData(query);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}