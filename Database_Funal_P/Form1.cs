using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LogIn_Button.Click += LogIn_Button_Click;
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            string username = User_TextBox.Text;
            string password = Password_TextBox.Text;

            if (


                  (username == "mahmoud" && password == "20240907") ||

                (username == "mohamed" && password == "20246235") || 

                (username == "yousef" && password == "20241857") || 

                (username == "hamza" && password == "20245360") || 

                (username == "abanoub" && password == "20240513")    
               )
            {
               

               
                 home form = new home();
                form.Show();
                 this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}