using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class UpdateParent : BaseForm
    {
        public UpdateParent()
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
                    $@"UPDATE Parent
                    SET Email = '{email.Text}'
                    WHERE Parent_ID = {Parent_id.Text}";

                    DatabaseHelper.Execute(query);
                }

                if (Phone.Enabled && Phone.Text != "")
                {
                    string query =
                    $@"INSERT INTO Parent_Phone
                    (Parent_ID, Phone)
                    VALUES
                    ({Parent_id.Text}, '{Phone.Text}')";

                    DatabaseHelper.Execute(query);
                }

                if (CurrentPhone.Enabled &&
                    CurrentPhone.Text != "" &&
                    NewPhone.Text != "")
                {
                    string query =
                    $@"UPDATE Parent_Phone
                    SET Phone = '{NewPhone.Text}'
                    WHERE Parent_ID = {Parent_id.Text}
                    AND Phone = '{CurrentPhone.Text}'";

                    DatabaseHelper.Execute(query);
                }

                if (PhoneTextb.Enabled &&
                    PhoneTextb.Text != "")
                {
                    string query =
                    $@"DELETE FROM Parent_Phone
                    WHERE Parent_ID = {Parent_id.Text}
                    AND Phone = '{PhoneTextb.Text}'";

                    DatabaseHelper.Execute(query);
                }

                MessageBox.Show("Parent Updated Successfully  ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}