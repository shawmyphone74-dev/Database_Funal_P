namespace Database_Funal_P
{
    partial class UpdateAttendance
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
            label3 = new Label();
            status = new ComboBox();
            label2 = new Label();
            date = new DateTimePicker();
            student_id = new TextBox();
            label1 = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 390);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(236, 154);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 20;
            label3.Text = "Status";
            // 
            // status
            // 
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Present", "Absent", "Late" });
            status.Location = new Point(363, 154);
            status.Name = "status";
            status.Size = new Size(121, 23);
            status.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(211, 88);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 18;
            label2.Text = "Attendance_Date";
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(363, 88);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 17;
            // 
            // student_id
            // 
            student_id.Location = new Point(363, 30);
            student_id.Name = "student_id";
            student_id.Size = new Size(100, 23);
            student_id.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(236, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 15;
            label1.Text = "Student_Id";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(663, 375);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(95, 43);
            AddButton.TabIndex = 14;
            AddButton.Text = "Update";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // UpdateAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(status);
            Controls.Add(label2);
            Controls.Add(date);
            Controls.Add(student_id);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Name = "UpdateAttendance";
            Text = "UpdateAttendance";
            Controls.SetChildIndex(AddButton, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(student_id, 0);
            Controls.SetChildIndex(date, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(status, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox status;
        private Label label2;
        private DateTimePicker date;
        private TextBox student_id;
        private Label label1;
        private Button AddButton;
    }
}