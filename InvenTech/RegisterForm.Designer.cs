namespace InvenTech
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            PasswordConfirm = new TextBox();
            label3 = new Label();
            Register = new Button();
            cmbRole = new ComboBox();
            label4 = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 34);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 115);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Username
            // 
            Username.Location = new Point(139, 57);
            Username.Name = "Username";
            Username.Size = new Size(200, 27);
            Username.TabIndex = 2;
            // 
            // Password
            // 
            Password.Location = new Point(139, 138);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(200, 27);
            Password.TabIndex = 3;
            // 
            // PasswordConfirm
            // 
            PasswordConfirm.Location = new Point(139, 211);
            PasswordConfirm.Name = "PasswordConfirm";
            PasswordConfirm.PasswordChar = '*';
            PasswordConfirm.Size = new Size(200, 27);
            PasswordConfirm.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 188);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // Register
            // 
            Register.Location = new Point(182, 358);
            Register.Name = "Register";
            Register.Size = new Size(94, 29);
            Register.TabIndex = 6;
            Register.Text = "Register!";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "User", "Admin" });
            cmbRole.Location = new Point(139, 291);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 28);
            cmbRole.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 268);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 8;
            label4.Text = "What type of user ?";
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 9;
            backButton.Text = "← Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += back_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(backButton);
            Controls.Add(label4);
            Controls.Add(cmbRole);
            Controls.Add(Register);
            Controls.Add(label3);
            Controls.Add(PasswordConfirm);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Username;
        private TextBox Password;
        private TextBox PasswordConfirm;
        private Label label3;
        private Button Register;
        private ComboBox cmbRole;
        private Label label4;
        private Button backButton;
    }
}