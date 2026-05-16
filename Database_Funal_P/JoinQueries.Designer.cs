// JoinQueries.Designer.cs

namespace Database_Funal_P
{
    partial class JoinQueries
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

        #region Windows Form Designer generated code

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
            BackButton.Location = new Point(3, 410);
            // 
            // QueryType
            // 
            QueryType.DropDownStyle = ComboBoxStyle.DropDownList;
            QueryType.FormattingEnabled = true;
            QueryType.Items.AddRange(new object[] { "Students With Parents", "Students With Classes", "Teachers With Managers", "Left Join Students And Attendance", "Students With Phones", "Teachers With Courses", "Courses With Classes", "Attendance With Student Names" });
            QueryType.Location = new Point(120, 70);
            QueryType.Name = "QueryType";
            QueryType.Size = new Size(280, 23);
            QueryType.TabIndex = 0;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(470, 60);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(120, 40);
            ExecuteButton.TabIndex = 1;
            ExecuteButton.Text = "Execute";
            ExecuteButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(720, 250);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(320, 20);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 3;
            label1.Text = "Join Queries";
            // 
            // JoinQueries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(ExecuteButton);
            Controls.Add(QueryType);
            Name = "JoinQueries";
            Text = "JoinQueries";
            Controls.SetChildIndex(QueryType, 0);
            Controls.SetChildIndex(ExecuteButton, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox QueryType;
        private Button ExecuteButton;
        private DataGridView dataGridView1;
        private Label label1;
    }
}