using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class AggregateQueries : BaseForm
    {
        public AggregateQueries()
        {
            InitializeComponent();

            ExecuteButton.Click += ExecuteButton_Click;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                
                // COUNT STUDENTS BY LEVEL
               

                if (QueryType.Text == "Students Count By Level")
                {
                    query = @"
                    SELECT 
                    Level,
                    COUNT(*) AS TotalStudents
                    FROM Student
                    GROUP BY Level";
                }

                
                // MAX TEACHER SALARY
                

                else if (QueryType.Text == "Maximum Teacher Salary")
                {
                    query = @"
                    SELECT 
                    MAX(Salary) AS MaxSalary
                    FROM Teacher";
                }

               
                // MIN CREDIT HOURS
                

                else if (QueryType.Text == "Minimum Credit Hours")
                {
                    query = @"
                    SELECT 
                    MIN(Credit_Hours) AS MinHours
                    FROM Course";
                }

             
                // CLASSES HAVING MORE THAN 2 STUDENTS
               

                else if (QueryType.Text ==
                         "Classes Having More Than 2 Students")
                {
                    query = @"
                    SELECT 
                    Class_ID,
                    COUNT(*) AS TotalStudents
                    FROM Student
                    GROUP BY Class_ID
                    HAVING COUNT(*) > 2";
                }

              
                // AVERAGE TEACHER SALARY
                
                else if (QueryType.Text ==
                         "Average Teacher Salary")
                {
                    query = @"
                    SELECT 
                    AVG(Salary) AS AverageSalary
                    FROM Teacher";
                }

               
                // TOTAL COURSES
               
                else if (QueryType.Text ==
                         "Total Courses")
                {
                    query = @"
                    SELECT 
                    COUNT(*) AS TotalCourses
                    FROM Course";
                }

                
                // TOTAL TEACHERS
               

                else if (QueryType.Text ==
                         "Total Teachers")
                {
                    query = @"
                    SELECT 
                    COUNT(*) AS TotalTeachers
                    FROM Teacher";
                }

               
                // TOTAL STUDENTS
              

                else if (QueryType.Text ==
                         "Total Students")
                {
                    query = @"
                    SELECT 
                    COUNT(*) AS TotalStudents
                    FROM Student";
                }

                // HIGHEST CREDIT HOURS
            
                else if (QueryType.Text ==
                         "Highest Credit Hours")
                {
                    query = @"
                    SELECT 
                    MAX(Credit_Hours) AS HighestHours
                    FROM Course";
                }

                
                // LOWEST TEACHER SALARY
           

                else if (QueryType.Text ==
                         "Lowest Teacher Salary")
                {
                    query = @"
                    SELECT 
                    MIN(Salary) AS LowestSalary
                    FROM Teacher";
                }

              
                // STUDENTS COUNT BY CLASS
              

                else if (QueryType.Text ==
                         "Students Count By Class")
                {
                    query = @"
                    SELECT 
                    Class_ID,
                    COUNT(*) AS TotalStudents
                    FROM Student
                    GROUP BY Class_ID";
                }

                
                // COURSES COUNT BY TEACHER

                else if (QueryType.Text ==
                         "Courses Count By Teacher")
                {
                    query = @"
                    SELECT 
                    Teacher_ID,
                    COUNT(*) AS TotalCourses
                    FROM Teaches
                    GROUP BY Teacher_ID";
                }

                else
                {
                    MessageBox.Show("Choose Query Type");
                    return;
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