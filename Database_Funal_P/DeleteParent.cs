using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class DeleteParent : BaseForm
    {
        public DeleteParent()
        {
            InitializeComponent();

            deleteButton.Click += deleteButton_Click;
        }

        private void DeleteParent_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (parent_Id.Text == "")
            {
                MessageBox.Show("Enter Parent ID");
                return;
            }

            try
            {
                string query = $@"
                DELETE FROM Parent
                WHERE Parent_ID =
                {int.Parse(parent_Id.Text)}";

                DatabaseHelper.Execute(query);

                MessageBox.Show("Deleted Successfully ");

                parent_Id.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}