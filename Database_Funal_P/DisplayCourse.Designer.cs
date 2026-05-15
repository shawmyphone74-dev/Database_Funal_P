// DisplayCourse.Designer.cs

namespace Database_Funal_P
{
    partial class DisplayCourse
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
            BackButton.Location = new Point(12, 410);
            // 
            // SearchType
            // 
            SearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchType.FormattingEnabled = true;
            SearchType.Items.AddRange(new object[] { "All Courses", "Course ID", "Course Name", "Credit Hours" });
            SearchType.Location = new Point(83, 70);
            SearchType.Name = "SearchType";
            SearchType.Size = new Size(180, 23);
            SearchType.TabIndex = 0;
            // 
            // SearchText
            // 
            SearchText.Location = new Point(311, 70);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(180, 23);
            SearchText.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(540, 60);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(120, 40);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(720, 250);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(310, 20);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 4;
            label1.Text = "Display Course";
            // 
            // DisplayCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(SearchButton);
            Controls.Add(SearchText);
            Controls.Add(SearchType);
            Name = "DisplayCourse";
            Text = "DisplayCourse";
            Controls.SetChildIndex(SearchType, 0);
            Controls.SetChildIndex(SearchText, 0);
            Controls.SetChildIndex(SearchButton, 0);
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

        private ComboBox SearchType;
        private TextBox SearchText;
        private Button SearchButton;
        private DataGridView dataGridView1;
        private Label label1;
    }
}