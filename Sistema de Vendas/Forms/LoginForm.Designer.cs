namespace Sistema_de_Vendas
{
    partial class Login
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
            txtUserLogin = new TextBox();
            txtUserPassword = new TextBox();
            lblUser = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUserLogin
            // 
            txtUserLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserLogin.Location = new Point(198, 107);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(191, 23);
            txtUserLogin.TabIndex = 0;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserPassword.Location = new Point(198, 167);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(191, 23);
            txtUserPassword.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(198, 89);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(198, 149);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(39, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Senha";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.Blue;
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(198, 238);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(191, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(598, 356);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserLogin;
        private TextBox txtUserPassword;
        private Label lblUser;
        private Label lblPassword;
        private Button btnLogin;
    }
}
