using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DisplayStudent : BaseForm
    {
        public DisplayStudent()
        {
            InitializeComponent();

            SearchButton.Click += SearchButton_Click;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                if (SearchType.Text == "All Students")
                {
                    query = @"
                    SELECT
                        Student.*
                        
                    FROM Student
                    ";
                }

                else if (SearchType.Text == "Student ID")
                {
                    query = $@"
                    SELECT
                        Student.*
                       
                    FROM Student
                    WHERE Student.Student_ID =
                    {SearchText.Text}";
                }

                else if (SearchType.Text == "First Name")
                {
                    query = $@"
                    SELECT
                        Student.*
                    FROM Student
                    WHERE Student.First_Name =
                    '{SearchText.Text}'";
                }

                else if (SearchType.Text == "Level")
                {
                    query = $@"
                    SELECT
                        Student.*
                    FROM Student
                    WHERE Student.Level =
                    '{SearchText.Text}'";
                }

                else if (SearchType.Text == "Class ID")
                {
                    query = $@"
                    SELECT
                        Student.*
                    FROM Student
                    WHERE Student.Class_ID =
                    {SearchText.Text}";
                }

                DataTable dt =
                    DatabaseHelper.GetData(query);

                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}