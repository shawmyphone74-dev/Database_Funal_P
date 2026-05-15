namespace Database_Funal_P
{
    partial class DeleteParent
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
            parent_Id = new TextBox();
            label2 = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // parent_Id
            // 
            parent_Id.Location = new Point(367, 74);
            parent_Id.Name = "parent_Id";
            parent_Id.Size = new Size(105, 23);
            parent_Id.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(253, 76);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 27;
            label2.Text = "Parent_Id";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(642, 351);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(106, 50);
            deleteButton.TabIndex = 26;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // DeleteParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(parent_Id);
            Controls.Add(label2);
            Controls.Add(deleteButton);
            Name = "DeleteParent";
            Text = "DeleteParent";
            Load += DeleteParent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox parent_Id;
        private Label label2;
        private Button deleteButton;
    }
}