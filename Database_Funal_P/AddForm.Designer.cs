namespace Database_Funal_P
{
    partial class AddForm
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
            label1 = new Label();
            StudentButton = new Button();
            ParentButton = new Button();
            TeacherButton = new Button();
            CourseButton = new Button();
            AttendanceButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(344, 77);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Add What ?";
            // 
            // StudentButton
            // 
            StudentButton.Location = new Point(48, 199);
            StudentButton.Name = "StudentButton";
            StudentButton.Size = new Size(94, 41);
            StudentButton.TabIndex = 1;
            StudentButton.Text = "Student";
            StudentButton.UseVisualStyleBackColor = true;
            // 
            // ParentButton
            // 
            ParentButton.Location = new Point(197, 199);
            ParentButton.Name = "ParentButton";
            ParentButton.Size = new Size(94, 41);
            ParentButton.TabIndex = 2;
            ParentButton.Text = "Parent";
            ParentButton.UseVisualStyleBackColor = true;
            // 
            // TeacherButton
            // 
            TeacherButton.Location = new Point(344, 199);
            TeacherButton.Name = "TeacherButton";
            TeacherButton.Size = new Size(94, 41);
            TeacherButton.TabIndex = 3;
            TeacherButton.Text = "Teacher";
            TeacherButton.UseVisualStyleBackColor = true;
            // 
            // CourseButton
            // 
            CourseButton.Location = new Point(499, 199);
            CourseButton.Name = "CourseButton";
            CourseButton.Size = new Size(94, 41);
            CourseButton.TabIndex = 4;
            CourseButton.Text = "Course";
            CourseButton.UseVisualStyleBackColor = true;
            // 
            // AttendanceButton
            // 
            AttendanceButton.Location = new Point(642, 199);
            AttendanceButton.Name = "AttendanceButton";
            AttendanceButton.Size = new Size(94, 41);
            AttendanceButton.TabIndex = 5;
            AttendanceButton.Text = "Attendance";
            AttendanceButton.UseVisualStyleBackColor = true;
            // 
            // AddForm
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
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button StudentButton;
        private Button ParentButton;
        private Button TeacherButton;
        private Button CourseButton;
        private Button AttendanceButton;
    }
}