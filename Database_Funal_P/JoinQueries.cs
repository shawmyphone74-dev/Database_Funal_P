using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class JoinQueries : BaseForm
    {
        public JoinQueries()
        {
            InitializeComponent();

            ExecuteButton.Click += ExecuteButton_Click;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                
                if (QueryType.Text == "Students With Parents")
                {
                    query =
                    @"SELECT
                        Student.Student_ID,
                        Student.First_Name,
                        Parent.First_Name AS Parent_Name
                    FROM Student
                    INNER JOIN Parent
                    ON Student.Parent_ID = Parent.Parent_ID";
                }

               

                else if (QueryType.Text == "Students With Classes")
                {
                    query =
                    @"SELECT
                        Student.Student_ID,
                        Student.First_Name,
                        Class.Class_ID,
                        Class.Level
                    FROM Student
                    INNER JOIN Class
                    ON Student.Class_ID = Class.Class_ID";
                }

               

                else if (QueryType.Text == "Teachers With Managers")
                {
                    query =
                    @"SELECT
                        T1.Teacher_ID,
                        T1.First_Name,
                        T2.First_Name AS Manager_Name
                    FROM Teacher T1
                    LEFT JOIN Teacher T2
                    ON T1.Manager_ID = T2.Teacher_ID";
                }

                


                else if (QueryType.Text ==
                         "Left Join Students And Attendance")
                {
                    query =
                    @"SELECT
                        Student.Student_ID,
                        Student.First_Name,
                        Attendance.Status
                    FROM Student
                    LEFT JOIN Attendance
                    ON Student.Student_ID = Attendance.Student_ID";
                }

               

                else if (QueryType.Text ==
                         "Students With Phones")
                {
                    query =
                    @"SELECT
                        Student.Student_ID,
                        Student.First_Name,
                        Student_Phone.Phone
                    FROM Student
                    INNER JOIN Student_Phone
                    ON Student.Student_ID =
                    Student_Phone.Student_ID";
                }

                else if (QueryType.Text ==
                         "Teachers With Courses")
                {
                    query =
                    @"SELECT
                        Teacher.Teacher_ID,
                        Teacher.First_Name,
                        Course.Course_Name
                    FROM Teacher
                    INNER JOIN Teaches
                    ON Teacher.Teacher_ID =
                    Teaches.Teacher_ID

                    INNER JOIN Course
                    ON Teaches.Course_ID =
                    Course.Course_ID";
                }

                

                else if (QueryType.Text ==
                         "Courses With Classes")
                {
                    query =
                    @"SELECT
                        Course.Course_Name,
                        Class.Class_ID
                        
                    FROM Course

                    INNER JOIN Contain
                    ON Course.Course_ID =
                    Contain.Course_ID

                    INNER JOIN Class
                    ON Contain.Class_ID =
                    Class.Class_ID";
                }




                else if (QueryType.Text ==
                         "Attendance With Student Names")
                {
                    query =
                    @"SELECT
                        Attendance.Student_ID,
                        Student.First_Name,
                        Attendance.Attendance_Date,
                        Attendance.Status
                    FROM Attendance

                    INNER JOIN Student
                    ON Attendance.Student_ID =
                    Student.Student_ID";
                }

                else
                {
                    MessageBox.Show("Choose Query");
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