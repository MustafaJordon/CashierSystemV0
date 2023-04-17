namespace cashierSystem_v0
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.shownUsername = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.addNewUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "username: ";
            // 
            // shownUsername
            // 
            this.shownUsername.Enabled = false;
            this.shownUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shownUsername.Location = new System.Drawing.Point(78, 12);
            this.shownUsername.Name = "shownUsername";
            this.shownUsername.Size = new System.Drawing.Size(100, 23);
            this.shownUsername.TabIndex = 4;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(139, 78);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(145, 23);
            this.username.TabIndex = 5;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(34, 81);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(59, 15);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(34, 112);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(139, 109);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(145, 23);
            this.password.TabIndex = 7;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(34, 148);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(27, 15);
            this.roleLabel.TabIndex = 12;
            this.roleLabel.Text = "role";
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Admin",
            "Branches Director",
            "Sales man",
            "CEO"});
            this.role.Location = new System.Drawing.Point(139, 148);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(145, 23);
            this.role.TabIndex = 13;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(139, 186);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(57, 19);
            this.isActive.TabIndex = 14;
            this.isActive.Text = "active";
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.Location = new System.Drawing.Point(139, 232);
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.Size = new System.Drawing.Size(134, 27);
            this.addNewUserButton.TabIndex = 15;
            this.addNewUserButton.Text = "Add user";
            this.addNewUserButton.UseVisualStyleBackColor = true;
            this.addNewUserButton.Click += new System.EventHandler(this.addNewUserButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::cashierSystem_v0.Properties.Resources.Picture2;
            this.ClientSize = new System.Drawing.Size(527, 348);
            this.Controls.Add(this.addNewUserButton);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.role);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shownUsername);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox shownUsername;
        private TextBox username;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox password;
        private Label roleLabel;
        private ComboBox role;
        private CheckBox isActive;
        private Button addNewUserButton;
    }
}