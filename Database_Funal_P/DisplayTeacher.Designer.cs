namespace Database_Funal_P
{
    partial class DisplayTeacher
    {
        private ComboBox SearchType;
        private TextBox SearchText;
        private Button SearchButton;
        private DataGridView dataGridView1;
        private Label label1;

        private void InitializeComponent()
        {
            SearchType = new ComboBox();
            SearchText = new TextBox();
            SearchButton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(8, 410);
            // 
            // SearchType
            // 
            SearchType.Items.AddRange(new object[] { "All Teachers", "Teacher ID", "First Name", "Last Name", "Specialization", "Salary", "Manager" });
            SearchType.Location = new Point(80, 70);
            SearchType.Name = "SearchType";
            SearchType.Size = new Size(180, 23);
            SearchType.TabIndex = 3;
            // 
            // SearchText
            // 
            SearchText.Location = new Point(300, 70);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(180, 23);
            SearchText.TabIndex = 4;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(520, 60);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(100, 40);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Location = new Point(40, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(720, 254);
            dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(300, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 7;
            label1.Text = "Display Teacher";
            // 
            // DisplayTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(SearchType);
            Controls.Add(SearchText);
            Controls.Add(SearchButton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "DisplayTeacher";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(SearchButton, 0);
            Controls.SetChildIndex(SearchText, 0);
            Controls.SetChildIndex(SearchType, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}