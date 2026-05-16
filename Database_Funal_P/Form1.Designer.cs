namespace Database_Funal_P
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogIn_Button = new Button();
            UserName_label = new Label();
            Password_Label = new Label();
            User_TextBox = new TextBox();
            Password_TextBox = new TextBox();
            SuspendLayout();
            // 
            // LogIn_Button
            // 
            LogIn_Button.ForeColor = SystemColors.ActiveCaptionText;
            LogIn_Button.Location = new Point(383, 282);
            LogIn_Button.Name = "LogIn_Button";
            LogIn_Button.Size = new Size(75, 44);
            LogIn_Button.TabIndex = 0;
            LogIn_Button.Text = "LogIn";
            LogIn_Button.UseVisualStyleBackColor = true;
            // 
            // UserName_label
            // 
            UserName_label.AutoSize = true;
            UserName_label.Font = new Font("Segoe UI", 14F);
            UserName_label.Location = new Point(223, 37);
            UserName_label.Name = "UserName_label";
            UserName_label.Size = new Size(105, 25);
            UserName_label.TabIndex = 1;
            UserName_label.Text = "User Name";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.BackColor = SystemColors.Control;
            Password_Label.Font = new Font("Segoe UI", 14F);
            Password_Label.Location = new Point(223, 126);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(91, 25);
            Password_Label.TabIndex = 2;
            Password_Label.Text = "Password";
            // 
            // User_TextBox
            // 
            User_TextBox.Location = new Point(355, 37);
            User_TextBox.Name = "User_TextBox";
            User_TextBox.Size = new Size(125, 23);
            User_TextBox.TabIndex = 3;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Location = new Point(355, 131);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.Size = new Size(125, 23);
            Password_TextBox.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password_TextBox);
            Controls.Add(User_TextBox);
            Controls.Add(Password_Label);
            Controls.Add(UserName_label);
            Controls.Add(LogIn_Button);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogIn_Button;
        private Label UserName_label;
        private Label Password_Label;
        private TextBox User_TextBox;
        private TextBox Password_TextBox;
    }
}
