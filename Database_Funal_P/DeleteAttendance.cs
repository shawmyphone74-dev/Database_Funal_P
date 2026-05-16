using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DeleteAttendance : BaseForm
    {
        public DeleteAttendance()
        {
            InitializeComponent();

            deleteButton.Click += deleteButton_Click;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Student_ID.Text == "")
                {
                    MessageBox.Show("Write Student ID");
                    return;
                }

                string query = $@"
                DELETE FROM Attendance
                WHERE Student_ID = {int.Parse(Student_ID.Text)}
                AND Attendance_Date = 
                '{dateTimePicker1.Value:yyyy-MM-dd}'";

                DatabaseHelper.Execute(query);

                MessageBox.Show("Attendance Deleted Successfully  ");

                Student_ID.Clear();

           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
