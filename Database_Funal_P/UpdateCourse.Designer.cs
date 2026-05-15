namespace Database_Funal_P
{
    partial class UpdateCourse
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
            credithour = new TextBox();
            label6 = new Label();
            name = new TextBox();
            label8 = new Label();
            course_id = new TextBox();
            label1 = new Label();
            UpdateparentButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 410);
            // 
            // credithour
            // 
            credithour.Location = new Point(382, 176);
            credithour.Name = "credithour";
            credithour.Size = new Size(100, 23);
            credithour.TabIndex = 98;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(253, 178);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 97;
            label6.Text = "Credit Hours";
            // 
            // name
            // 
            name.Location = new Point(382, 101);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 96;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(273, 99);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 95;
            label8.Text = "Name";
            // 
            // course_id
            // 
            course_id.Location = new Point(382, 40);
            course_id.Name = "course_id";
            course_id.Size = new Size(100, 23);
            course_id.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(273, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 93;
            label1.Text = "Course-Id";
            // 
            // UpdateparentButton
            // 
            UpdateparentButton.Location = new Point(654, 398);
            UpdateparentButton.Name = "UpdateparentButton";
            UpdateparentButton.Size = new Size(117, 40);
            UpdateparentButton.TabIndex = 99;
            UpdateparentButton.Text = "Update";
            UpdateparentButton.UseVisualStyleBackColor = true;
            // 
            // UpdateCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateparentButton);
            Controls.Add(credithour);
            Controls.Add(label6);
            Controls.Add(name);
            Controls.Add(label8);
            Controls.Add(course_id);
            Controls.Add(label1);
            Name = "UpdateCourse";
            Text = "UpdateCourse";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(course_id, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(name, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(credithour, 0);
            Controls.SetChildIndex(UpdateparentButton, 0);
            Controls.SetChildIndex(LogoutButton, 0);
            Controls.SetChildIndex(HomeButton, 0);
            Controls.SetChildIndex(BackButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox credithour;
        private Label label6;
        private TextBox name;
        private Label label8;
        private TextBox course_id;
        private Label label1;
        private Button UpdateparentButton;
    }
}