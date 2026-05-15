using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class AddTeacher : BaseForm
    {
        public AddTeacher()
        {
            InitializeComponent();

            AddButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string managerValue;

                if (ManagerId.Text == "")
                {
                    managerValue = "NULL";
                }
                else
                {
                    managerValue = ManagerId.Text;
                }

                string query = $@"
                INSERT INTO Teacher
                (
                    Teacher_ID,
                    First_Name,
                    Last_Name,
                    Email,
                    Specialization,
                    Hire_Date,
                    Salary,
                    Manager_ID
                )
                VALUES
                (
                    {int.Parse(teacher_id.Text)},
                    '{fristname.Text}',
                    '{lastname.Text}',
                    '{email.Text}',
                    '{specializiation.Text}',
                    '{hiredate.Value:yyyy-MM-dd}',
                    {decimal.Parse(salary.Text)},
                    {managerValue}
                )";

                DatabaseHelper.ExecuteQuery(query);

                MessageBox.Show("Teacher Added Successfully  ");

                teacher_id.Clear();
                fristname.Clear();
                lastname.Clear();
                email.Clear();
                specializiation.Clear();
                salary.Clear();
                ManagerId.Clear();

                hiredate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}