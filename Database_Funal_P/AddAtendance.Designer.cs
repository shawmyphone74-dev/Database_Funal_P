namespace Database_Funal_P
{
    partial class AddAtendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            course_id = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(669, 367);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(95, 43);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // course_id
            // 
            course_id.Location = new Point(353, 50);
            course_id.Name = "course_id";
            course_id.Size = new Size(100, 23);
            course_id.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(226, 50);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 8;
            label1.Text = "Student_Id";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(353, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(201, 108);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 11;
            label2.Text = "Attendance_Date";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Present", "Absent", "Late" });
            comboBox1.Location = new Point(353, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(226, 174);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 13;
            label3.Text = "Status";
            // 
            // AddAtendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(course_id);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Name = "AddAtendance";
            Text = "AddAtendance";
            Controls.SetChildIndex(AddButton, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(course_id, 0);
            Controls.SetChildIndex(dateTimePicker1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private TextBox course_id;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
    }
}