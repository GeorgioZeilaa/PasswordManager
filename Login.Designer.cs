
namespace PasswordManager
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
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.lbl_login_incorrect_info = new System.Windows.Forms.Label();
            this.lbl_login_fill_field = new System.Windows.Forms.Label();
            this.lbl_login_failed_login = new System.Windows.Forms.Label();
            this.btn_login_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_login_username
            // 
            this.txt_login_username.Location = new System.Drawing.Point(311, 111);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(100, 20);
            this.txt_login_username.TabIndex = 0;
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Location = new System.Drawing.Point(250, 114);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_login_username.TabIndex = 1;
            this.lbl_login_username.Text = "Username:";
            // 
            // btn_login_login
            // 
            this.btn_login_login.Location = new System.Drawing.Point(323, 175);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login_login.TabIndex = 2;
            this.btn_login_login.Text = "Login";
            this.btn_login_login.UseVisualStyleBackColor = true;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Location = new System.Drawing.Point(250, 144);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_login_password.TabIndex = 3;
            this.lbl_login_password.Text = "Password:";
            // 
            // txt_login_password
            // 
            this.txt_login_password.Location = new System.Drawing.Point(311, 144);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.Size = new System.Drawing.Size(100, 20);
            this.txt_login_password.TabIndex = 1;
            // 
            // lbl_login_incorrect_info
            // 
            this.lbl_login_incorrect_info.AutoSize = true;
            this.lbl_login_incorrect_info.Location = new System.Drawing.Point(417, 147);
            this.lbl_login_incorrect_info.Name = "lbl_login_incorrect_info";
            this.lbl_login_incorrect_info.Size = new System.Drawing.Size(153, 13);
            this.lbl_login_incorrect_info.TabIndex = 5;
            this.lbl_login_incorrect_info.Text = "Username/Password incorrect!";
            // 
            // lbl_login_fill_field
            // 
            this.lbl_login_fill_field.AutoSize = true;
            this.lbl_login_fill_field.Location = new System.Drawing.Point(297, 95);
            this.lbl_login_fill_field.Name = "lbl_login_fill_field";
            this.lbl_login_fill_field.Size = new System.Drawing.Size(139, 13);
            this.lbl_login_fill_field.TabIndex = 6;
            this.lbl_login_fill_field.Text = "Make sure all filled are filled!";
            // 
            // lbl_login_failed_login
            // 
            this.lbl_login_failed_login.AutoSize = true;
            this.lbl_login_failed_login.Location = new System.Drawing.Point(404, 180);
            this.lbl_login_failed_login.Name = "lbl_login_failed_login";
            this.lbl_login_failed_login.Size = new System.Drawing.Size(75, 13);
            this.lbl_login_failed_login.TabIndex = 7;
            this.lbl_login_failed_login.Text = "Failed to login!";
            // 
            // btn_login_reset
            // 
            this.btn_login_reset.Location = new System.Drawing.Point(233, 175);
            this.btn_login_reset.Name = "btn_login_reset";
            this.btn_login_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_login_reset.TabIndex = 8;
            this.btn_login_reset.Text = "Reset";
            this.btn_login_reset.UseVisualStyleBackColor = true;
            this.btn_login_reset.Click += new System.EventHandler(this.btn_login_reset_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login_reset);
            this.Controls.Add(this.lbl_login_failed_login);
            this.Controls.Add(this.lbl_login_fill_field);
            this.Controls.Add(this.lbl_login_incorrect_info);
            this.Controls.Add(this.txt_login_password);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.btn_login_login);
            this.Controls.Add(this.lbl_login_username);
            this.Controls.Add(this.txt_login_username);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login_username;
        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Button btn_login_login;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.Label lbl_login_incorrect_info;
        private System.Windows.Forms.Label lbl_login_fill_field;
        private System.Windows.Forms.Label lbl_login_failed_login;
        private System.Windows.Forms.Button btn_login_reset;
    }
}