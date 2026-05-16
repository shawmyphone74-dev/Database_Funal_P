namespace Database_Funal_P
{
    partial class DeleteTeacher
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
            teacher_Id = new TextBox();
            label2 = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // teacher_Id
            // 
            teacher_Id.Location = new Point(363, 72);
            teacher_Id.Name = "teacher_Id";
            teacher_Id.Size = new Size(105, 23);
            teacher_Id.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(249, 74);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 30;
            label2.Text = "Teacher_Id";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(638, 349);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(106, 50);
            deleteButton.TabIndex = 29;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // DeleteTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(teacher_Id);
            Controls.Add(label2);
            Controls.Add(deleteButton);
            Name = "DeleteTeacher";
            Text = "DeleteTeacher";
            Controls.SetChildIndex(deleteButton, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(teacher_Id, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teacher_Id;
        private Label label2;
        private Button deleteButton;
    }
}