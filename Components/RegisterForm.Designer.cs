namespace Register_Login_System
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
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lbPassword = new Label();
            lbUsername = new Label();
            txtConfirmPassword = new TextBox();
            lbConfirmPassword = new Label();
            btnReturn = new Button();
            lbEmail = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(335, 331);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(114, 40);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(335, 218);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(239, 27);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(335, 163);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(239, 27);
            txtUsername.TabIndex = 9;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(173, 221);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Mật khẩu:";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(173, 166);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(110, 20);
            lbUsername.TabIndex = 7;
            lbUsername.Text = "Tên đăng nhập:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(335, 276);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(239, 27);
            txtConfirmPassword.TabIndex = 14;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(173, 276);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(133, 20);
            lbConfirmPassword.TabIndex = 13;
            lbConfirmPassword.Text = "Nhập lại mật khẩu:";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(460, 331);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(114, 40);
            btnReturn.TabIndex = 15;
            btnReturn.Text = "Hủy";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnCancel_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(173, 113);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(49, 20);
            lbEmail.TabIndex = 16;
            lbEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(335, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 27);
            txtEmail.TabIndex = 17;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(btnReturn);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Name = "RegisterForm";
            Text = "RegisterForm";
            FormClosing += RegisterForm_FormClosing;
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lbPassword;
        private Label lbUsername;
        private TextBox txtConfirmPassword;
        private Label lbConfirmPassword;
        private Button btnReturn;
        private Label lbEmail;
        private TextBox txtEmail;
    }
}