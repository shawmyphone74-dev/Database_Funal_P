namespace Database_Funal_P
{
    partial class AddCourse
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
            coursename = new TextBox();
            label2 = new Label();
            course_id = new TextBox();
            label1 = new Label();
            credithour = new TextBox();
            label3 = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // coursename
            // 
            coursename.Location = new Point(348, 101);
            coursename.Name = "coursename";
            coursename.Size = new Size(100, 23);
            coursename.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(221, 101);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 8;
            label2.Text = "Course Name";
            // 
            // course_id
            // 
            course_id.Location = new Point(348, 39);
            course_id.Name = "course_id";
            course_id.Size = new Size(100, 23);
            course_id.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(221, 39);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 6;
            label1.Text = "Course_Id";
            // 
            // credithour
            // 
            credithour.Location = new Point(348, 166);
            credithour.Name = "credithour";
            credithour.Size = new Size(100, 23);
            credithour.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(221, 166);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 10;
            label3.Text = "Credit Hours";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(650, 333);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(95, 43);
            AddButton.TabIndex = 12;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // AddCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
            Controls.Add(credithour);
            Controls.Add(label3);
            Controls.Add(coursename);
            Controls.Add(label2);
            Controls.Add(course_id);
            Controls.Add(label1);
            Name = "AddCourse";
            Text = "AddCourse";
            Load += AddCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox coursename;
        private Label label2;
        private TextBox course_id;
        private Label label1;
        private TextBox credithour;
        private Label label3;
        private Button AddButton;
    }
}