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
            QueryType.SelectedIndexChanged += QueryType_SelectedIndexChanged;
            SQBox.Enabled = false;
        }

        private void QueryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = QueryType.Text.Trim();

            if (selected == "Courses Credit Hours Greater Than" ||
                selected == "Courses Credit Hours Less Than" ||
                selected == "Teachers Take Salary Greater Than" ||
                selected == "Teachers Take Salary Less Than")
            {
                SQBox.Enabled = true;
                SQBox.Focus();
            }
            else
            {
                SQBox.Enabled = false;
                SQBox.Clear();
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                string selectedQuery = QueryType.Text.Trim();

                if (SQBox.Enabled && string.IsNullOrWhiteSpace(SQBox.Text))
                {
                    MessageBox.Show("Please enter a value first.");
                    return;
                }

                if (selectedQuery == "High Level Students")
                {
                    query =
                    @"SELECT *
                    FROM Student
                    WHERE Level='High'
                    ORDER BY First_Name";
                }
                if (selectedQuery == "Primary Level Students")
                {
                    query =
                    @"SELECT *
                    FROM Student
                    WHERE Level='Primary'
                    ORDER BY First_Name";
                }
                else if (selectedQuery == "Teachers Ordered By Salary")
                {
                    query =
                    @"SELECT *
                    FROM Teacher
                    ORDER BY Salary DESC";
                }
                else if (selectedQuery == "Courses Ordered By Credit Hours")
                {
                    query =
                    @"SELECT *
                    FROM Course
                    ORDER BY Credit_Hours";
                }
               
                
                else if (selectedQuery == "Courses Credit Hours Greater Than")
                {
                    if (!int.TryParse(SQBox.Text, out int ch1))
                    {
                        MessageBox.Show("Invalid number");
                        return;
                    }

                    query =
                    $@"SELECT * FROM Course 
                    WHERE Credit_Hours > {ch1} 
                    ORDER BY Credit_Hours";
                }
                else if (selectedQuery == "Middle Level Students")
                {
                    query =
                    @"SELECT *
                    FROM Student
                    WHERE Level = 'Middle'";
                }
                else if (selectedQuery == "Teachers Ordered By Salary Ascending")
                {
                    query =
                    @"SELECT *
                    FROM Teacher
                    ORDER BY Salary";
                }
                else if (selectedQuery == "Teachers Ordered By Salary Descending")
                {
                    query =
                    @"SELECT *
                    FROM Teacher
                    ORDER BY Salary DESC";
                }
                else if (selectedQuery == "Courses Ordered By Credit Hours Ascending")
                {
                    query =
                    @"SELECT *
                    FROM Course
                    ORDER BY Credit_Hours";
                }
                else if (selectedQuery == "Courses Ordered By Credit Hours Descending")
                {
                    query =
                    @"SELECT *
                    FROM Course
                    ORDER BY Credit_Hours DESC";
                }
                else if (selectedQuery == "Students Ordered By Name Ascending")
                {
                    query =
                    @"SELECT *
                    FROM Student
                    ORDER BY First_Name";
                }
                else if (selectedQuery == "Students Ordered By Name Descending")
                {
                    query =
                    @"SELECT *
                    FROM Student
                    ORDER BY First_Name DESC";
                }
                else if (selectedQuery == "Courses Credit Hours Less Than")
                {
                    if (!int.TryParse(SQBox.Text, out int ch2))
                    {
                        MessageBox.Show("Invalid number");
                        return;
                    }

                    query =
                    $@"SELECT * FROM Course 
                    WHERE Credit_Hours < {ch2} 
                    ORDER BY Credit_Hours";
                }
                else if (selectedQuery == "Teachers Take Salary Greater Than")
                {
                    if (!decimal.TryParse(SQBox.Text, out decimal s1))
                    {
                        MessageBox.Show("Invalid salary");
                        return;
                    }

                    query =
                    $@"SELECT * FROM Teacher 
                    WHERE Salary > {s1} 
                    ORDER BY Salary";
                }
                else if (selectedQuery == "Teachers Take Salary Less Than")
                {
                    if (!decimal.TryParse(SQBox.Text, out decimal s2))
                    {
                        MessageBox.Show("Invalid salary");
                        return;
                    }

                    query =
                    $@"SELECT * FROM Teacher 
                    WHERE Salary < {s2} 
                    ORDER BY Salary";
                }

                if (!string.IsNullOrEmpty(query))
                {
                    DataTable dt = DatabaseHelper.GetData(query);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}