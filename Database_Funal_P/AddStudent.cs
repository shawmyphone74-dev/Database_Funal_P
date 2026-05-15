using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class AddStudent : BaseForm
    {
        public AddStudent()
        {
            InitializeComponent();

            AddStudentButton.Click += AddStudentButton_Click;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string studentQuery = $@"
                INSERT INTO Student
                (
                    Student_ID,
                    Parent_ID,
                    Class_ID,
                    First_Name,
                    Last_Name,
                    Gender,
                    Level,
                    Date_Of_Birth,
                    Email,
                    Address
                )
                VALUES
                (
                    {int.Parse(student_id.Text)},
                    {int.Parse(parnt_id.Text)},
                    {int.Parse(classid.Text)},
                    '{frist_name.Text}',
                    '{last_name.Text}',
                    '{gander.Text}',
                    '{level.Text}',
                    '{dateofbirth.Value:yyyy-MM-dd}',
                    '{email.Text}',
                    '{address.Text}'
                )";

                DatabaseHelper.ExecuteQuery(studentQuery);

                string phoneQuery = $@"
                INSERT INTO Student_Phone
                (
                    Student_ID,
                    Phone
                )
                VALUES
                (
                    {int.Parse(student_id.Text)},
                    '{phone.Text}'
                )";

                DatabaseHelper.ExecuteQuery(phoneQuery);

                MessageBox.Show("Student Added Successfully  ");

                student_id.Clear();
                parnt_id.Clear();
                classid.Clear();
                frist_name.Clear();
                last_name.Clear();
                gander.SelectedIndex=-1;
                level.SelectedIndex = -1;
                email.Clear();
                address.Clear();
                phone.Clear();

                dateofbirth.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}