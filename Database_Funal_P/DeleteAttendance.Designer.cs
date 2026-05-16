namespace Database_Funal_P
{
    partial class DeleteAttendance
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
            Student_ID = new TextBox();
            label2 = new Label();
            deleteButton = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // Student_ID
            // 
            Student_ID.Location = new Point(356, 41);
            Student_ID.Name = "Student_ID";
            Student_ID.Size = new Size(105, 23);
            Student_ID.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(225, 39);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 27;
            label2.Text = "Student_Id";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(639, 360);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(106, 50);
            deleteButton.TabIndex = 26;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(225, 136);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 29;
            label1.Text = "Attendance_Id";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(356, 134);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // DeleteAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(Student_ID);
            Controls.Add(label2);
            Controls.Add(deleteButton);
            Name = "DeleteAttendance";
            Text = "DeleteAttendance";
            Controls.SetChildIndex(deleteButton, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(Student_ID, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(dateTimePicker1, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Student_ID;
        private Label label2;
        private Button deleteButton;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}