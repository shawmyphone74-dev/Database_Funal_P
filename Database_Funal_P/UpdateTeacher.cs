using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class UpdateTeacher : BaseForm
    {
        public UpdateTeacher()
        {
            InitializeComponent();

            Phone.Enabled = false;
            CurrentPhone.Enabled = false;
            NewPhone.Enabled = false;
            PhoneTextb.Enabled = false;

            Add.Click += Add_Click;
            Replace.Click += Replace_Click;
            Delete.Click += Delete_Click;
            UpdateparentButton.Click += UpdateparentButton_Click;
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

        private void UpdateparentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (email.Text != "")
                {
                    string query =
                    $@"UPDATE Teacher
                    SET Email = '{email.Text}'
                    WHERE Teacher_ID = {Teacher_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                if (Salary.Text != "")
                {
                    string query =
                    $@"UPDATE Teacher
                    SET Salary = {Salary.Text}
                    WHERE Teacher_ID = {Teacher_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                if (Manager_Id.Text != "")
                {
                    string query =
                    $@"UPDATE Teacher
                    SET Manager_ID = {Manager_Id.Text}
                    WHERE Teacher_ID = {Teacher_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                if (Phone.Enabled && Phone.Text != "")
                {
                    string query =
                    $@"INSERT INTO Teacher_Phone
                    (Teacher_ID, Phone)
                    VALUES
                    ({Teacher_id.Text}, '{Phone.Text}')";

                    DatabaseHelper.Execute(query);
                }

                if (CurrentPhone.Enabled &&
                    CurrentPhone.Text != "" &&
                    NewPhone.Text != "")
                {
                    string query =
                    $@"UPDATE Teacher_Phone
                    SET Phone = '{NewPhone.Text}'
                    WHERE Teacher_ID = {Teacher_id.Text}
                    AND Phone = '{CurrentPhone.Text}'";

                    DatabaseHelper.Execute(query);
                }

                if (PhoneTextb.Enabled &&
                    PhoneTextb.Text != "")
                {
                    string query =
                    $@"DELETE FROM Teacher_Phone
                    WHERE Teacher_ID = {Teacher_id.Text}
                    AND Phone = '{PhoneTextb.Text}'";

                    DatabaseHelper.Execute(query);
                }

                MessageBox.Show("Teacher Updated Successfully ✔");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}