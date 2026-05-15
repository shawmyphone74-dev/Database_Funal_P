namespace Database_Funal_P
{
    partial class DeleteStudent
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
            deleteButton = new Button();
            student_Id = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 382);
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(644, 360);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(106, 50);
            deleteButton.TabIndex = 23;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // student_Id
            // 
            student_Id.Location = new Point(355, 62);
            student_Id.Name = "student_Id";
            student_Id.Size = new Size(105, 23);
            student_Id.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(232, 60);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 24;
            label2.Text = "Student_Id";
            // 
            // DeleteStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(student_Id);
            Controls.Add(label2);
            Controls.Add(deleteButton);
            Name = "DeleteStudent";
            Text = "DeleteStudent";
            Load += DeleteStudent_Load;
            Controls.SetChildIndex(deleteButton, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(student_Id, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private TextBox student_Id;
        private Label label2;
    }
}