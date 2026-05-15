

using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class SimpleQueries : BaseForm
    {
        public SimpleQueries()
        {
            InitializeComponent();

            ExecuteButton.Click += ExecuteButton_Click;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                if (QueryType.Text == "High Level Students")
                {
                    query =
                    @"SELECT *
                    FROM Student
                    WHERE Level='High'
                    ORDER BY First_Name";
                }

                else if (QueryType.Text ==
                         "Teachers Ordered By Salary")
                {
                    query =
                    @"SELECT *
                    FROM Teacher
                    ORDER BY Salary DESC";
                }

                else if (QueryType.Text ==
                         "Courses Ordered By Credit Hours")
                {
                    query =
                    @"SELECT *
                    FROM Course
                    ORDER BY Credit_Hours";
                }

                else if (QueryType.Text ==
                         "Students Ordered By Name")
                {
                    query =
                    @"SELECT *
                    FROM Student
                    ORDER BY First_Name";
                }

                else if (QueryType.Text ==
                         "Teachers Salary Greater Than 5000")
                {
                    query =
                    @"SELECT *
                    FROM Teacher
                    WHERE Salary > 5000
                    ORDER BY Salary DESC";
                }

                else if (QueryType.Text ==
                         "Courses Credit Hours Greater Than 2")
                {
                    query =
                    @"SELECT *
                    FROM Course
                    WHERE Credit_Hours > 2
                    ORDER BY Credit_Hours";
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