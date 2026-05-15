using Microsoft.VisualBasic.Logging;
using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            BackButton.Click += BackButton_Click;
            HomeButton.Click += HomeButton_Click;
            LogoutButton.Click += LogoutButton_Click;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
            if (this is home)
            {
                return;
            }

           
            else if (this is AddStudent ||
                     this is AddParent ||
                     this is AddCourse ||
                     this is AddAtendance)
            {
                AddForm h = new AddForm();
                h.Show();
                this.Close();
            }

           
            else if (this is UpdateStudent ||
                     this is UpdateParent ||
                     this is UpdateCourse ||
                     this is UpdateAttendance)
            {
                Update h = new Update();
                h.Show();
                this.Close();
            }

            
            else if (this is DeleteStudent ||
                     this is DeleteParent ||
                     this is DeleteCourse ||
                     this is DeleteAttendance ||
                     this is DeleteTeacher)
            {
                Delete h = new Delete();
                h.Show();
                this.Close();
            }

           
            else if (this is DisplayStudent ||
                     this is DisplayParent ||
                     this is DisplayCourse ||
                     this is DisplayAttendance)
            {
                Display h = new Display();
                h.Show();
                this.Close();
            }

           
            else 
            {
                home h = new home();
                h.Show();
                this.Close();
            }

            //this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
{
    if (this is home)
        return;

    home h = new home();

    h.Show();

    this.Close();
}

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();

            login.Show();

            this.Close();
        }
    }
}