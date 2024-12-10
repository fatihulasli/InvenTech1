namespace InvenTech
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            OldPassword = new TextBox();
            NewPassword = new TextBox();
            ConfirmNewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ChangePasswordButton = new Button();
            SuspendLayout();
            // 
            // OldPassword
            // 
            OldPassword.Location = new Point(132, 80);
            OldPassword.Name = "OldPassword";
            OldPassword.PasswordChar = '*';
            OldPassword.Size = new Size(200, 27);
            OldPassword.TabIndex = 0;
            // 
            // NewPassword
            // 
            NewPassword.Location = new Point(132, 178);
            NewPassword.Name = "NewPassword";
            NewPassword.PasswordChar = '*';
            NewPassword.Size = new Size(200, 27);
            NewPassword.TabIndex = 1;
            // 
            // ConfirmNewPassword
            // 
            ConfirmNewPassword.Location = new Point(132, 270);
            ConfirmNewPassword.Name = "ConfirmNewPassword";
            ConfirmNewPassword.PasswordChar = '*';
            ConfirmNewPassword.Size = new Size(200, 27);
            ConfirmNewPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 57);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 3;
            label1.Text = "Current Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 155);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 247);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 5;
            label3.Text = "Confirm New Password";
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Location = new Point(153, 332);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(150, 29);
            ChangePasswordButton.TabIndex = 6;
            ChangePasswordButton.Text = "Change Password";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(482, 453);
            Controls.Add(ChangePasswordButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ConfirmNewPassword);
            Controls.Add(NewPassword);
            Controls.Add(OldPassword);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OldPassword;
        private TextBox NewPassword;
        private TextBox ConfirmNewPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ChangePasswordButton;
    }
}