namespace Database_Funal_P
{
    partial class AddStudent
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
            AddStudentButton = new Button();
            label1 = new Label();
            student_id = new TextBox();
            frist_name = new TextBox();
            label2 = new Label();
            last_name = new TextBox();
            label3 = new Label();
            parnt_id = new TextBox();
            label4 = new Label();
            label5 = new Label();
            gander = new ComboBox();
            level = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            dateofbirth = new DateTimePicker();
            label8 = new Label();
            address = new TextBox();
            email = new TextBox();
            label9 = new Label();
            classid = new TextBox();
            label10 = new Label();
            label11 = new Label();
            phone = new TextBox();
            SuspendLayout();
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(625, 366);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(117, 40);
            AddStudentButton.TabIndex = 0;
            AddStudentButton.Text = "Add";
            AddStudentButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(259, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 1;
            label1.Text = "Student-Id";
            // 
            // student_id
            // 
            student_id.Location = new Point(377, 19);
            student_id.Name = "student_id";
            student_id.Size = new Size(100, 23);
            student_id.TabIndex = 2;
            // 
            // frist_name
            // 
            frist_name.Location = new Point(377, 62);
            frist_name.Name = "frist_name";
            frist_name.Size = new Size(100, 23);
            frist_name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(252, 62);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 3;
            label2.Text = "Frist_Name";
            // 
            // last_name
            // 
            last_name.Location = new Point(377, 108);
            last_name.Name = "last_name";
            last_name.Size = new Size(100, 23);
            last_name.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(249, 110);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 5;
            label3.Text = "Last_Name";
            // 
            // parnt_id
            // 
            parnt_id.Location = new Point(377, 156);
            parnt_id.Name = "parnt_id";
            parnt_id.Size = new Size(100, 23);
            parnt_id.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(252, 156);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 7;
            label4.Text = "Parent_Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(257, 197);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // gander
            // 
            gander.DropDownStyle = ComboBoxStyle.DropDownList;
            gander.FormattingEnabled = true;
            gander.Items.AddRange(new object[] { "Female", "Male" });
            gander.Location = new Point(377, 199);
            gander.Name = "gander";
            gander.Size = new Size(121, 23);
            gander.TabIndex = 10;
            // 
            // level
            // 
            level.DropDownStyle = ComboBoxStyle.DropDownList;
            level.FormattingEnabled = true;
            level.Items.AddRange(new object[] { "Primary", "Middle", "High" });
            level.Location = new Point(377, 248);
            level.Name = "level";
            level.Size = new Size(121, 23);
            level.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(259, 246);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 11;
            label6.Text = "Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(244, 294);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 13;
            label7.Text = "Date Of Birth";
            // 
            // dateofbirth
            // 
            dateofbirth.Format = DateTimePickerFormat.Short;
            dateofbirth.Location = new Point(377, 292);
            dateofbirth.Name = "dateofbirth";
            dateofbirth.Size = new Size(141, 23);
            dateofbirth.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(539, 27);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 15;
            label8.Text = "Email";
            // 
            // address
            // 
            address.Location = new Point(636, 68);
            address.Name = "address";
            address.Size = new Size(100, 23);
            address.TabIndex = 16;
            // 
            // email
            // 
            email.Location = new Point(636, 25);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(539, 70);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 17;
            label9.Text = "Address";
            // 
            // classid
            // 
            classid.Location = new Point(377, 339);
            classid.Name = "classid";
            classid.Size = new Size(100, 23);
            classid.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(252, 339);
            label10.Name = "label10";
            label10.Size = new Size(66, 21);
            label10.TabIndex = 19;
            label10.Text = "Class_Id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(539, 114);
            label11.Name = "label11";
            label11.Size = new Size(54, 21);
            label11.TabIndex = 22;
            label11.Text = "Phone";
            // 
            // phone
            // 
            phone.Location = new Point(636, 112);
            phone.Name = "phone";
            phone.Size = new Size(100, 23);
            phone.TabIndex = 21;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(phone);
            Controls.Add(classid);
            Controls.Add(label10);
            Controls.Add(email);
            Controls.Add(label9);
            Controls.Add(address);
            Controls.Add(label8);
            Controls.Add(dateofbirth);
            Controls.Add(label7);
            Controls.Add(level);
            Controls.Add(label6);
            Controls.Add(gander);
            Controls.Add(label5);
            Controls.Add(parnt_id);
            Controls.Add(label4);
            Controls.Add(last_name);
            Controls.Add(label3);
            Controls.Add(frist_name);
            Controls.Add(label2);
            Controls.Add(student_id);
            Controls.Add(label1);
            Controls.Add(AddStudentButton);
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddStudentButton;
        private Label label1;
        private TextBox student_id;
        private TextBox frist_name;
        private Label label2;
        private TextBox last_name;
        private Label label3;
        private TextBox parnt_id;
        private Label label4;
        private Label label5;
        private ComboBox gander;
        private ComboBox level;
        private Label label6;
        private Label label7;
        private DateTimePicker dateofbirth;
        private Label label8;
        private TextBox address;
        private TextBox email;
        private Label label9;
        private TextBox classid;
        private Label label10;
        private Label label11;
        private TextBox phone;
    }
}