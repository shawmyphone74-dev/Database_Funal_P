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
                string query;
                if (ManageridText.Text == "")
                {
                    
                    query = $@"
                INSERT INTO Teacher
                (
                    Teacher_ID,
                    First_Name,
                    Last_Name,
                    Email,
                    Specialization,
                    Hire_Date,
                    Salary,
                    Type,
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
                    '{Type.Text}',
                    {"Null"}

                )";

                }
                else
                {
                    
                    query = $@"
                INSERT INTO Teacher
                (
                    Teacher_ID,
                    First_Name,
                    Last_Name,
                    Email,
                    Specialization,
                    Hire_Date,
                    Salary,
                    Type,
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
                    '{Type.Text}',
                     {int.Parse(ManageridText.Text)},

                )";
                }


                    DatabaseHelper.Execute(query);

                MessageBox.Show("Teacher Added Successfully  ");

                teacher_id.Clear();
                fristname.Clear();
                lastname.Clear();
                email.Clear();
                specializiation.Clear();
                salary.Clear();
                ManageridText.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}