

using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DisplayParent : BaseForm
    {
        public DisplayParent()
        {
            InitializeComponent();

            SearchButton.Click += SearchButton_Click;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                if (SearchType.Text == "All Parents")
                {
                    query = @"
                    SELECT *
                        
                    FROM Parent"
                    ;
                }

                else if (SearchType.Text == "Parent ID")
                {
                    query = @"
                    SELECT*
                    FROM Parent
                    WHERE Parent.Parent_ID = " + SearchText.Text;
                }

                else if (SearchType.Text == "First Name")
                {
                    query = @"
                    SELECT *
                        
                    FROM Parent
                    
                    WHERE Parent.First_Name LIKE '%" + SearchText.Text + "%'";
                }

                else if (SearchType.Text == "Last Name")
                {
                    query = @"
                    SELECT *
                       
                    FROM Parent
                   
                    WHERE Parent.Last_Name LIKE '%" + SearchText.Text + "%'";
                }

                else if (SearchType.Text == "Email")
                {
                    query = @"
                    SELECT *
                        
                    FROM Parent
                   
                    WHERE Parent.Email LIKE '%" + SearchText.Text + "%'";
                }

                else if (SearchType.Text == "Relation")
                {
                    query = @"
                    SELECT *
                    FROM Parent
                    
                    WHERE Parent.Relation_With_Student LIKE '%" + SearchText.Text + "%'";
                }

                DataTable dt = DatabaseHelper.GetData(query);

                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}