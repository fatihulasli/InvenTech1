namespace InvenTech
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            Login = new Button();
            Register = new Button();
            Username = new TextBox();
            Password = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(191, 63);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Location = new Point(196, 159);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Login
            // 
            Login.Location = new Point(191, 250);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 2;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Register
            // 
            Register.Location = new Point(191, 377);
            Register.Name = "Register";
            Register.Size = new Size(94, 29);
            Register.TabIndex = 3;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // Username
            // 
            Username.Location = new Point(135, 86);
            Username.Name = "Username";
            Username.Size = new Size(200, 27);
            Username.TabIndex = 4;
            // 
            // Password
            // 
            Password.Location = new Point(135, 197);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(200, 27);
            Password.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Location = new Point(147, 332);
            label3.Name = "label3";
            label3.Size = new Size(175, 20);
            label3.TabIndex = 6;
            label3.Text = "Don't you have account ?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(482, 453);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Register);
            Controls.Add(Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Login;
        private Button Register;
        private TextBox Username;
        private TextBox Password;
        private Label label3;
    }
}