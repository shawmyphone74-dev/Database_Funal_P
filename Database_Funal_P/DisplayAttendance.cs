
using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DisplayAttendance : BaseForm
    {
        public DisplayAttendance()
        {
            InitializeComponent();

            SearchButton.Click += SearchButton_Click;

            SearchType.SelectedIndex = 0;

            LoadAllAttendance();
        }

        private void LoadAllAttendance()
        {
            string query = @"
            SELECT
                A.Student_ID,
                S.First_Name + ' ' + S.Last_Name AS Student_Name,
                A.Attendance_Date,
                A.Status
            FROM Attendance A
            INNER JOIN Student S
            ON A.Student_ID = S.Student_ID";

            DataTable dt = DatabaseHelper.GetData(query);

            dataGridView1.DataSource = dt;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                if (SearchType.Text == "All Attendance")
                {
                    LoadAllAttendance();
                    return;
                }

                else if (SearchType.Text == "Student ID")
                {
                    query = $@"
                    SELECT
                        A.Student_ID,
                        S.First_Name + ' ' + S.Last_Name AS Student_Name,
                        A.Attendance_Date,
                        A.Status
                    FROM Attendance A
                    INNER JOIN Student S
                    ON A.Student_ID = S.Student_ID
                    WHERE A.Student_ID = {SearchText.Text}";
                }

                else if (SearchType.Text == "Student Name")
                {
                    query = $@"
                    SELECT
                        A.Student_ID,
                        S.First_Name + ' ' + S.Last_Name AS Student_Name,
                        A.Attendance_Date,
                        A.Status
                    FROM Attendance A
                    INNER JOIN Student S
                    ON A.Student_ID = S.Student_ID
                    WHERE
                    S.First_Name + ' ' + S.Last_Name
                    LIKE '%{SearchText.Text}%'";
                }

                else if (SearchType.Text == "Status")
                {
                    query = $@"
                    SELECT
                        A.Student_ID,
                        S.First_Name + ' ' + S.Last_Name AS Student_Name,
                        A.Attendance_Date,
                        A.Status
                    FROM Attendance A
                    INNER JOIN Student S
                    ON A.Student_ID = S.Student_ID
                    WHERE A.Status LIKE '%{SearchText.Text}%'";
                }

                DataTable dt = DatabaseHelper.GetData(query);

                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}