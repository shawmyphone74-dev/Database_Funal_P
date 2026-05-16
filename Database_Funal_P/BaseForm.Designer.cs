namespace Database_Funal_P
{
    partial class BaseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            BackButton = new Button();
            HomeButton = new Button();
            LogoutButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 382);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(66, 28);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(12, 12);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(62, 30);
            HomeButton.TabIndex = 1;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(12, 60);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(62, 31);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(BackButton);
            Controls.Add(HomeButton);
            Controls.Add(LogoutButton);
            Name = "BaseForm";
            Text = "BaseForm";
            ResumeLayout(false);
        }

        #endregion

        protected System.Windows.Forms.Button BackButton;
        protected System.Windows.Forms.Button HomeButton;
        protected System.Windows.Forms.Button LogoutButton;
    }
}