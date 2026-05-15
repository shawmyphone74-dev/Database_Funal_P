namespace Database_Funal_P
{
    partial class Display
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
            AttendanceButton = new Button();
            CourseButton = new Button();
            TeacherButton = new Button();
            ParentButton = new Button();
            StudentButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 399);
            // 
            // AttendanceButton
            // 
            AttendanceButton.Location = new Point(632, 171);
            AttendanceButton.Name = "AttendanceButton";
            AttendanceButton.Size = new Size(94, 41);
            AttendanceButton.TabIndex = 11;
            AttendanceButton.Text = "Attendance";
            AttendanceButton.UseVisualStyleBackColor = true;
            // 
            // CourseButton
            // 
            CourseButton.Location = new Point(489, 171);
            CourseButton.Name = "CourseButton";
            CourseButton.Size = new Size(94, 41);
            CourseButton.TabIndex = 10;
            CourseButton.Text = "Course";
            CourseButton.UseVisualStyleBackColor = true;
            // 
            // TeacherButton
            // 
            TeacherButton.Location = new Point(334, 171);
            TeacherButton.Name = "TeacherButton";
            TeacherButton.Size = new Size(94, 41);
            TeacherButton.TabIndex = 9;
            TeacherButton.Text = "Teacher";
            TeacherButton.UseVisualStyleBackColor = true;
            // 
            // ParentButton
            // 
            ParentButton.Location = new Point(187, 171);
            ParentButton.Name = "ParentButton";
            ParentButton.Size = new Size(94, 41);
            ParentButton.TabIndex = 8;
            ParentButton.Text = "Parent";
            ParentButton.UseVisualStyleBackColor = true;
            // 
            // StudentButton
            // 
            StudentButton.Location = new Point(38, 171);
            StudentButton.Name = "StudentButton";
            StudentButton.Size = new Size(94, 41);
            StudentButton.TabIndex = 7;
            StudentButton.Text = "Student";
            StudentButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(322, 58);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 6;
            label1.Text = "Display What ?";
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AttendanceButton);
            Controls.Add(CourseButton);
            Controls.Add(TeacherButton);
            Controls.Add(ParentButton);
            Controls.Add(StudentButton);
            Controls.Add(label1);
            Name = "Display";
            Text = "Display";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(StudentButton, 0);
            Controls.SetChildIndex(ParentButton, 0);
            Controls.SetChildIndex(TeacherButton, 0);
            Controls.SetChildIndex(CourseButton, 0);
            Controls.SetChildIndex(AttendanceButton, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AttendanceButton;
        private Button CourseButton;
        private Button TeacherButton;
        private Button ParentButton;
        private Button StudentButton;
        private Label label1;
    }
}