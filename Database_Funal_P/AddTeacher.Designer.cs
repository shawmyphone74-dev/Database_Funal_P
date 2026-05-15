namespace Database_Funal_P
{
    partial class AddTeacher
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
            label1 = new Label();
            teacher_id = new TextBox();
            fristname = new TextBox();
            label2 = new Label();
            lastname = new TextBox();
            label3 = new Label();
            email = new TextBox();
            label4 = new Label();
            specializiation = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ManagerId = new TextBox();
            label7 = new Label();
            salary = new TextBox();
            label8 = new Label();
            hiredate = new DateTimePicker();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(665, 365);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(95, 43);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(243, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 1;
            label1.Text = "Teacher_Id";
            // 
            // teacher_id
            // 
            teacher_id.Location = new Point(351, 12);
            teacher_id.Name = "teacher_id";
            teacher_id.Size = new Size(100, 23);
            teacher_id.TabIndex = 3;
            // 
            // fristname
            // 
            fristname.Location = new Point(351, 56);
            fristname.Name = "fristname";
            fristname.Size = new Size(100, 23);
            fristname.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(241, 58);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 4;
            label2.Text = "Frist Name";
            // 
            // lastname
            // 
            lastname.Location = new Point(351, 104);
            lastname.Name = "lastname";
            lastname.Size = new Size(100, 23);
            lastname.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(243, 106);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // email
            // 
            email.Location = new Point(351, 151);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(272, 153);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // specializiation
            // 
            specializiation.Location = new Point(351, 196);
            specializiation.Name = "specializiation";
            specializiation.Size = new Size(100, 23);
            specializiation.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(234, 198);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 10;
            label5.Text = "Specialization";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(243, 247);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 12;
            label6.Text = "Hire Date";
            // 
            // ManagerId
            // 
            ManagerId.Location = new Point(351, 348);
            ManagerId.Name = "ManagerId";
            ManagerId.Size = new Size(100, 23);
            ManagerId.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(235, 350);
            label7.Name = "label7";
            label7.Size = new Size(92, 21);
            label7.TabIndex = 16;
            label7.Text = "Manager_Id";
            // 
            // salary
            // 
            salary.Location = new Point(351, 298);
            salary.Name = "salary";
            salary.Size = new Size(100, 23);
            salary.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(265, 300);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 14;
            label8.Text = "Salary";
            // 
            // hiredate
            // 
            hiredate.Format = DateTimePickerFormat.Short;
            hiredate.Location = new Point(351, 247);
            hiredate.Name = "hiredate";
            hiredate.Size = new Size(200, 23);
            hiredate.TabIndex = 18;
            // 
            // AddTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hiredate);
            Controls.Add(ManagerId);
            Controls.Add(label7);
            Controls.Add(salary);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(specializiation);
            Controls.Add(label5);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(lastname);
            Controls.Add(label3);
            Controls.Add(fristname);
            Controls.Add(label2);
            Controls.Add(teacher_id);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Name = "AddTeacher";
            Text = "AddTeacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label label1;
        private TextBox teacher_id;
        private TextBox fristname;
        private Label label2;
        private TextBox lastname;
        private Label label3;
        private TextBox email;
        private Label label4;
        private TextBox specializiation;
        private Label label5;
        private Label label6;
        private TextBox ManagerId;
        private Label label7;
        private TextBox salary;
        private Label label8;
        private DateTimePicker hiredate;
    }
}