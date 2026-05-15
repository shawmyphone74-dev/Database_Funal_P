using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class UpdateAttendance : BaseForm
    {
        public UpdateAttendance()
        {
            InitializeComponent();

            AddButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query =
                $@"UPDATE Attendance
                SET Status = '{status.Text}'
                WHERE Student_ID = {student_id.Text}
                AND Attendance_Date = '{date.Value.Date:yyyy-MM-dd}'";

                DatabaseHelper.Execute(query);

                MessageBox.Show("Attendance Updated Successfully ✔");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}