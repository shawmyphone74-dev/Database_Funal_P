

namespace Database_Funal_P
{
    partial class SimpleQueries
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            QueryType = new ComboBox();
            ExecuteButton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 410);
            // 
            // QueryType
            // 
            QueryType.DropDownStyle = ComboBoxStyle.DropDownList;
            QueryType.FormattingEnabled = true;
            QueryType.Items.AddRange(new object[] { "High Level Students", "Teachers Ordered By Salary", "Courses Ordered By Credit Hours", "Students Ordered By Name", "Teachers Salary Greater Than 5000", "Courses Credit Hours Greater Than 2" });
            QueryType.Location = new Point(120, 70);
            QueryType.Name = "QueryType";
            QueryType.Size = new Size(280, 23);
            QueryType.TabIndex = 3;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(470, 60);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(120, 40);
            ExecuteButton.TabIndex = 4;
            ExecuteButton.Text = "Execute";
            ExecuteButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(720, 250);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(300, 20);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 6;
            label1.Text = "Simple Queries";
            // 
            // SimpleQueries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(QueryType);
            Controls.Add(ExecuteButton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "SimpleQueries";
            Text = "SimpleQueries";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(ExecuteButton, 0);
            Controls.SetChildIndex(QueryType, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox QueryType;
        private Button ExecuteButton;
        private DataGridView dataGridView1;
        private Label label1;
    }
}