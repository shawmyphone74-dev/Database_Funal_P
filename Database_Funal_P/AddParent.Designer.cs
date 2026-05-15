namespace Database_Funal_P
{
    partial class AddParent
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
            relationwithstudent = new TextBox();
            label4 = new Label();
            lastname = new TextBox();
            label3 = new Label();
            fristname = new TextBox();
            label2 = new Label();
            Parent_id = new TextBox();
            label1 = new Label();
            email = new TextBox();
            label5 = new Label();
            phone = new TextBox();
            label6 = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // relationwithstudent
            // 
            relationwithstudent.Location = new Point(381, 171);
            relationwithstudent.Name = "relationwithstudent";
            relationwithstudent.Size = new Size(100, 23);
            relationwithstudent.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(309, 230);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 16;
            label4.Text = "Phone";
            // 
            // lastname
            // 
            lastname.Location = new Point(381, 115);
            lastname.Name = "lastname";
            lastname.Size = new Size(100, 23);
            lastname.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(283, 117);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 14;
            label3.Text = "Last Name";
            // 
            // fristname
            // 
            fristname.Location = new Point(381, 67);
            fristname.Name = "fristname";
            fristname.Size = new Size(100, 23);
            fristname.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(283, 69);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 12;
            label2.Text = "Frist Name";
            // 
            // Parent_id
            // 
            Parent_id.Location = new Point(381, 23);
            Parent_id.Name = "Parent_id";
            Parent_id.Size = new Size(100, 23);
            Parent_id.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(283, 25);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 10;
            label1.Text = "Parent_Id";
            // 
            // email
            // 
            email.Location = new Point(381, 286);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(200, 171);
            label5.Name = "label5";
            label5.Size = new Size(157, 21);
            label5.TabIndex = 18;
            label5.Text = "Relation with student";
            // 
            // phone
            // 
            phone.Location = new Point(381, 228);
            phone.Name = "phone";
            phone.Size = new Size(100, 23);
            phone.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(309, 288);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 20;
            label6.Text = "Email";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(665, 358);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(95, 43);
            AddButton.TabIndex = 22;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // AddParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
            Controls.Add(phone);
            Controls.Add(label6);
            Controls.Add(email);
            Controls.Add(label5);
            Controls.Add(relationwithstudent);
            Controls.Add(label4);
            Controls.Add(lastname);
            Controls.Add(label3);
            Controls.Add(fristname);
            Controls.Add(label2);
            Controls.Add(Parent_id);
            Controls.Add(label1);
            Name = "AddParent";
            Text = "AddParent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox relationwithstudent;
        private Label label4;
        private TextBox lastname;
        private Label label3;
        private TextBox fristname;
        private Label label2;
        private TextBox Parent_id;
        private Label label1;
        private TextBox email;
        private Label label5;
        private TextBox phone;
        private Label label6;
        private Button AddButton;
    }
}