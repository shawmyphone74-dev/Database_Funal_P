using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class AddAtendance : BaseForm
    {
        public AddAtendance()
        {
            InitializeComponent();

            AddButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (course_id.Text == "" ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            int studentId;

            if (!int.TryParse(course_id.Text, out studentId))
            {
                MessageBox.Show("Student ID must be a number");
                return;
            }

            string status = comboBox1.SelectedItem.ToString();

            DateTime attendanceDate =
            dateTimePicker1.Value.Date;

            try
            {
                string query = $@"
                INSERT INTO Attendance
                (
                    Attendance_Date,
                    Student_ID,
                    Status
                )
                VALUES
                (
                    '{attendanceDate:yyyy-MM-dd}',
                    {studentId},
                    '{status}'
                )";

                DatabaseHelper.ExecuteQuery(query);

                MessageBox.Show("Attendance Added Successfully  ");

                course_id.Clear();

                comboBox1.SelectedIndex = -1;

                dateTimePicker1.Value = DateTime.Now;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Attendance already exists  ");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}