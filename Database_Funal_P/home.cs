using Microsoft.VisualBasic.Devices;
using System;
using System.Windows.Forms;

namespace Database_Funal_P
{
    public partial class home : Form
    {
        public home()
        {
       
            InitializeComponent();

        AddButton.Click += AddButton_Click;
            DeleteButton.Click += DeleteButton_Click;
        
            UpdateButton.Click += UpdateButton_Click;
            DisplayButton.Click += DisplayButton_Click;
            SimpleQueries.Click += SimpleQueries_Click;
            JoinQueries.Click += JoinQueries_Click; 
            Aggregatequeries.Click += Aggregatequeries_Click;
            SubQueries.Click += SubQueries_Click;
            BackButton.Click += BackButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(); 
            form.Show();
            this.Close();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete form = new Delete();
            form.Show();
            this.Close();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Update form = new Update(); 
            form.Show();
            this.Close();
        }
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            Display form = new Display(); 
            form.Show();
            this.Close();
        }
        private void SimpleQueries_Click(object sender, EventArgs e)
        {
            SimpleQueries form = new SimpleQueries();
            form.Show();
            this.Close();
        }
        private void JoinQueries_Click(object sender, EventArgs e)
        {
            JoinQueries form = new JoinQueries ();
            form.Show();
            this.Close();
        }
        private void Aggregatequeries_Click(object sender, EventArgs e)
        {
            AggregateQueries form = new AggregateQueries();
            form.Show();
            this.Close();
        }
        private void SubQueries_Click(object sender, EventArgs e)
        {
            SubQueries form = new SubQueries();
            form.Show();
            this.Close();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }
        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}