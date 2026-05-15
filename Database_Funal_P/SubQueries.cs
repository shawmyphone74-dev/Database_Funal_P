using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class SubQueries : BaseForm
    {
        public SubQueries()
        {
            InitializeComponent();

            ExecuteButton.Click += ExecuteButton_Click;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                if (QueryType.Text == "Teachers With Max Salary")
                {
                    query =
                    @"SELECT *
                    FROM Teacher
                    WHERE Salary =
                    (
                        SELECT MAX(Salary)
                        FROM Teacher
                    )";
                }

                else if (QueryType.Text == "Teachers With Min Salary")
                {
                    query =
                    @"SELECT *
                    FROM Teacher
                    WHERE Salary =
                    (
                        SELECT MIN(Salary)
                        FROM Teacher
                    )";
                }

                else if (QueryType.Text ==
                         "Courses With Max Credit Hours")
                {
                    query =
                    @"SELECT *
                    FROM Course
                    WHERE Credit_Hours =
                    (
                        SELECT MAX(Credit_Hours)
                        FROM Course
                    )";
                }

                else if (QueryType.Text ==
                         "Courses With Minimum Credit Hours")
                {
                    query =
                    @"SELECT *
                    FROM Course
                    WHERE Credit_Hours =
                    (
                        SELECT MIN(Credit_Hours)
                        FROM Course
                    )";
                }

                else if (QueryType.Text ==
                         "Students In Highest Class")
                {
                    query =
                    @"SELECT *
                    FROM Student
                    WHERE Class_ID =
                    (
                        SELECT MAX(Class_ID)
                        FROM Student
                    )";
                }

                else if (QueryType.Text ==
                         "Students In Lowest Class")
                {
                    query =
                    @"SELECT *
                    FROM Student
                    WHERE Class_ID =
                    (
                        SELECT MIN(Class_ID)
                        FROM Student
                    )";
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