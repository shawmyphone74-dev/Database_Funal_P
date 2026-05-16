using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class AddParent : BaseForm
    {
        public AddParent()
        {
            InitializeComponent();

            AddButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string parentQuery = $@"
                INSERT INTO Parent
                (
                    Parent_ID,
                    First_Name,
                    Last_Name,
                    Relation_With_Student,
                    Email
                )
                VALUES
                (
                    {int.Parse(Parent_id.Text)},
                    '{fristname.Text}',
                    '{lastname.Text}',
                    '{relationwithstudent.Text}',
                    '{email.Text}'
                )";

                DatabaseHelper.Execute(parentQuery);

                string phoneQuery = $@"
                INSERT INTO Parent_Phone
                (
                    Parent_ID,
                    Phone
                )
                VALUES
                (
                    {int.Parse(Parent_id.Text)},
                    '{phone.Text}'
                )";

                DatabaseHelper.Execute(phoneQuery);

                MessageBox.Show("Parent Added Successfully");

                Parent_id.Clear();
                fristname.Clear();
                lastname.Clear();
                relationwithstudent.Clear();
                email.Clear();
                phone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}