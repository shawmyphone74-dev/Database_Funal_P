namespace Database_Funal_P
{
    partial class home
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
            DisplayButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            homeLabel = new Label();
            SimpleQueries = new Button();
            Aggregatequeries = new Button();
            SubQueries = new Button();
            JoinQueries = new Button();
            BackButton = new Button();
          
            SuspendLayout();
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(611, 159);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(101, 43);
            DisplayButton.TabIndex = 3;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(444, 159);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(105, 43);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(271, 164);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(113, 43);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(93, 159);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 48);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.Font = new Font("Segoe UI", 14F);
            homeLabel.Location = new Point(271, 73);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(232, 25);
            homeLabel.TabIndex = 7;
            homeLabel.Text = "WHAT'S ON YOUR MIND ?";
            // 
            // SimpleQueries
            // 
            SimpleQueries.Location = new Point(93, 266);
            SimpleQueries.Name = "SimpleQueries";
            SimpleQueries.Size = new Size(104, 49);
            SimpleQueries.TabIndex = 8;
            SimpleQueries.Text = "SimpleQueries";
            SimpleQueries.UseVisualStyleBackColor = true;
            // 
            // Aggregatequeries
            // 
            Aggregatequeries.Location = new Point(271, 266);
            Aggregatequeries.Name = "Aggregatequeries";
            Aggregatequeries.Size = new Size(113, 49);
            Aggregatequeries.TabIndex = 9;
            Aggregatequeries.Text = "AggregateQueries";
            Aggregatequeries.UseVisualStyleBackColor = true;
            // 
            // SubQueries
            // 
            SubQueries.Location = new Point(444, 266);
            SubQueries.Name = "SubQueries";
            SubQueries.Size = new Size(105, 49);
            SubQueries.TabIndex = 10;
            SubQueries.Text = "SubQueries";
            SubQueries.UseVisualStyleBackColor = true;
            // 
            // JoinQueries
            // 
            JoinQueries.Location = new Point(611, 266);
            JoinQueries.Name = "JoinQueries";
            JoinQueries.Size = new Size(101, 49);
            JoinQueries.TabIndex = 11;
            JoinQueries.Text = "JoinQueries";
            JoinQueries.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 395);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(82, 33);
            BackButton.TabIndex = 12;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // TeAdmin
            // 
           
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
           
            Controls.Add(BackButton);
            Controls.Add(JoinQueries);
            Controls.Add(SubQueries);
            Controls.Add(Aggregatequeries);
            Controls.Add(SimpleQueries);
            Controls.Add(homeLabel);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(DisplayButton);
            Name = "home";
            Text = "home";
            Load += home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DisplayButton;
        private Button button4;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button AddButton;
        private Label homeLabel;
        private Button SimpleQueries;
        private Button Aggregatequeries;
        private Button SubQueries;
        private Button JoinQueries;
        private Button BackButton;
       
    }
}