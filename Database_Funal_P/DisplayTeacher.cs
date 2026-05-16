using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DisplayTeacher : BaseForm
    {
        public DisplayTeacher()
        {
            InitializeComponent();

            SearchButton.Click += SearchButton_Click;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                if (SearchType.Text == "All Teachers")
                {
                    query =
                    @"SELECT *
                       
                    FROM Teacher ";


                }

                else if (SearchType.Text == "Teacher ID")
                {
                    query =
                    $@"SELECT *
                        
                      
                    FROM Teacher
                    WHERE Teacher.Teacher_ID = {SearchText.Text}";
                }

                else if (SearchType.Text == "Frist Name")
                {
                    query =
                    $@"SELECT *
                        
                      
                    FROM Teacher 

                    

                    WHERE Teacher.First_Name = '{SearchText.Text}'";

                }
                else if (SearchType.Text == "Last Name")
                {
                    query =
                    $@"SELECT *
                        
                      
                    FROM Teacher 

                    

                    WHERE Teacher.Last_Name = '{SearchText.Text}'
                   ";
                }
                else if (SearchType.Text == "Specialization")
                {
                    query =
                    $@"SELECT *
                        
                      
                    FROM Teacher 

                    WHERE Teacher .Specialization = '{SearchText.Text}'";
                }

                else if (SearchType.Text == "Salary")
                {
                    query =
                    $@"SELECT *
                       
                      
                    FROM Teacher 


                    WHERE Teacher.Salary = {SearchText.Text}";
                }

                else if (SearchType.Text == "Manager")
                {

                    if (SearchText.Text == "")
                    {
                        query =
                        @"SELECT *
                           
                          
                          FROM Teacher 

                          

                          WHERE Type='Manager'";
                    }


                    else
                    {
                        query =
                        $@"SELECT *
                            
                          
                          FROM Teacher 
                         
                          WHERE Teacher.Manager_ID = {SearchText.Text}";
                    }
                }

                DataTable dt =
                    DatabaseHelper.GetData(query);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}