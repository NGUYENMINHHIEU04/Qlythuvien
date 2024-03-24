namespace WindowsFormsApp3
{
    partial class Login
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExitAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExitUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassworduser = new System.Windows.Forms.TextBox();
            this.tbEmailuser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnExitAdmin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Username);
            this.tabPage1.Controls.Add(this.tbPassword);
            this.tabPage1.Controls.Add(this.tbEmail);
            this.tabPage1.Controls.Add(this.btn_login);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(325, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "WELCOME ADMIN";
            // 
            // btnExitAdmin
            // 
            this.btnExitAdmin.Location = new System.Drawing.Point(175, 267);
            this.btnExitAdmin.Name = "btnExitAdmin";
            this.btnExitAdmin.Size = new System.Drawing.Size(379, 34);
            this.btnExitAdmin.TabIndex = 11;
            this.btnExitAdmin.Text = "Exit";
            this.btnExitAdmin.UseVisualStyleBackColor = true;
            this.btnExitAdmin.Click += new System.EventHandler(this.btnExitAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(172, 114);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(41, 16);
            this.Username.TabIndex = 9;
            this.Username.Text = "Email";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(270, 170);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(284, 22);
            this.tbPassword.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(270, 108);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(284, 22);
            this.tbEmail.TabIndex = 7;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(175, 225);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(379, 35);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnExitUser);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbPassworduser);
            this.tabPage2.Controls.Add(this.tbEmailuser);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Fuchsia;
            this.label5.Location = new System.Drawing.Point(304, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "WELCOME USER";
            // 
            // btnExitUser
            // 
            this.btnExitUser.Location = new System.Drawing.Point(158, 270);
            this.btnExitUser.Name = "btnExitUser";
            this.btnExitUser.Size = new System.Drawing.Size(379, 34);
            this.btnExitUser.TabIndex = 12;
            this.btnExitUser.Text = "Exit";
            this.btnExitUser.UseVisualStyleBackColor = true;
            this.btnExitUser.Click += new System.EventHandler(this.btnExitUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // tbPassworduser
            // 
            this.tbPassworduser.Location = new System.Drawing.Point(253, 174);
            this.tbPassworduser.Name = "tbPassworduser";
            this.tbPassworduser.PasswordChar = '*';
            this.tbPassworduser.Size = new System.Drawing.Size(284, 22);
            this.tbPassworduser.TabIndex = 8;
            // 
            // tbEmailuser
            // 
            this.tbEmailuser.Location = new System.Drawing.Point(253, 112);
            this.tbEmailuser.Name = "tbEmailuser";
            this.tbEmailuser.Size = new System.Drawing.Size(284, 22);
            this.tbEmailuser.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassworduser;
        private System.Windows.Forms.TextBox tbEmailuser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExitAdmin;
        private System.Windows.Forms.Button btnExitUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}