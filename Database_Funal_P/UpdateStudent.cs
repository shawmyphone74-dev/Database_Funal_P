using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class UpdateStudent : BaseForm
    {
        public UpdateStudent()
        {
            InitializeComponent();

            Phone.Enabled = false;
            CurrentPhone.Enabled = false;
            NewPhone.Enabled = false;
            PhoneTextb.Enabled = false;

            Add.Click += Add_Click;
            Replace.Click += Replace_Click;
            Delete.Click += Delete_Click;
            UpdateStudentButton.Click += UpdateStudentButton_Click;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Phone.Enabled = true;
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            CurrentPhone.Enabled = true;
            NewPhone.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            PhoneTextb.Enabled = true;
        }

        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (level.Text != "")
                {
                    string query =
                    $@"UPDATE Student
                    SET Level = '{level.Text}'
                    WHERE Student_ID = {student_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                if (classid.Text != "")
                {
                    string query =
                    $@"UPDATE Student
                    SET Class_ID = {classid.Text}
                    WHERE Student_ID = {student_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                if (email.Text != "")
                {
                    string query =
                    $@"UPDATE Student
                    SET Email = '{email.Text}'
                    WHERE Student_ID = {student_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                if (address.Text != "")
                {
                    string query =
                    $@"UPDATE Student
                    SET Address = '{address.Text}'
                    WHERE Student_ID = {student_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                if (Phone.Enabled && Phone.Text != "")
                {
                    string query =
                    $@"INSERT INTO Student_Phone
                    (Student_ID, Phone)
                    VALUES
                    ({student_id.Text}, '{Phone.Text}')";

                    DatabaseHelper.Execute(query);
                }

                if (CurrentPhone.Enabled &&
                    CurrentPhone.Text != "" &&
                    NewPhone.Text != "")
                {
                    string query =
                    $@"UPDATE Student_Phone
                    SET Phone = '{NewPhone.Text}'
                    WHERE Student_ID = {student_id.Text}
                    AND Phone = '{CurrentPhone.Text}'";

                    DatabaseHelper.Execute(query);
                }

                if (PhoneTextb.Enabled &&
                    PhoneTextb.Text != "")
                {
                    string query =
                    $@"DELETE FROM Student_Phone
                    WHERE Student_ID = {student_id.Text}
                    AND Phone = '{PhoneTextb.Text}'";

                    DatabaseHelper.Execute(query);
                }

                MessageBox.Show("Student Updated Successfully ✔");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
